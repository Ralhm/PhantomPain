using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoard : MonoBehaviour
{

    public Texture2D texture;
    public Vector2 textureSize = new Vector2(x: 2048, y: 2048); 


    // Start is called before the first frame update
    void Awake()
    {
        var r = GetComponent<Renderer>();
        texture = new Texture2D(width: (int)textureSize.x, height: (int)textureSize.y);
        r.material.mainTexture = texture;
        //r.material.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
