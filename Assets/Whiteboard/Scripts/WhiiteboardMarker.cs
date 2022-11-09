using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WhiiteboardMarker : MonoBehaviour

{
    [SerializeField] private Transform tip;
    [SerializeField] private int penSize =5;

    private Renderer _renderer;
    private Color[] color;
    private float _tipHieght;

    private RaycastHit _touch;
    private WhiteBoard whiteboard; 
    private Vector2 _touchPos, _lastTouchPos;
    private bool _touchedLastFrame;
    private Quaternion _lastTouchRot;
    private Color[] shiftingColor;


    void Start()
    {
        _renderer = tip.GetComponent<Renderer>();
        color = Enumerable.Repeat(_renderer.material.color, penSize * penSize).ToArray();
        shiftingColor = Enumerable.Repeat(_renderer.material.color, penSize * penSize).ToArray();
        _tipHieght = tip.localScale.y;
        StartCoroutine(ShiftColor());

        print(shiftingColor.Length);
    }

    void Update()
    {
        Draw(); 
    }

    private void Draw()
    {
        if (Physics.Raycast(tip.position, transform.up, out _touch, _tipHieght))
        {
            if (_touch.transform.CompareTag("Whiteboard"))
            {
                if (whiteboard == null)
                { 
                    whiteboard = _touch.transform.GetComponent<WhiteBoard>();
                }

                _touchPos = new Vector2(_touch.textureCoord.x, _touch.textureCoord.y);
                var x = (int)(_touchPos.x * whiteboard.textureSize.x - (penSize / 2));
                var y = (int)(_touchPos.y * whiteboard.textureSize.y - (penSize / 2));

                if (y < 0 || y > whiteboard.textureSize.y || x < 0 || x > whiteboard.textureSize.x) return; 
                
                    if (_touchedLastFrame)
                    {
                        whiteboard.texture.SetPixels(x, y, penSize, penSize, shiftingColor);

                        for (float f = 0.01f; f < 1.00f; f += 0.01f)
                        {
                            var lerpX = (int)Mathf.Lerp(_lastTouchPos.x, x, f);
                            var lerpY = (int)Mathf.Lerp(_lastTouchPos.y, y, f);
                            whiteboard.texture.SetPixels(lerpX, lerpY, penSize, penSize, shiftingColor);
                        }

                        transform.rotation = _lastTouchRot; 
                        whiteboard.texture.Apply();

                    }
                    _lastTouchPos = new Vector2(x, y); 
                    _lastTouchRot = transform.rotation;
                    _touchedLastFrame = true;
                    return; 
                }
            }
            whiteboard = null;
            _touchedLastFrame = false; 
        
        }

    IEnumerator ShiftColor()
    {
        while (true)
        {

            _renderer.material.color = new Color(Mathf.Sin(Time.time * 2.5f), Mathf.Sin(Time.time * 1.5f), Mathf.Sin(Time.time * 2), 1);
            shiftingColor = Enumerable.Repeat(_renderer.material.color, penSize * penSize).ToArray(); //I have no idea how expensive this is but whatever, it looks cool
            yield return new WaitForSeconds(0.1f);
        }
    }

}

