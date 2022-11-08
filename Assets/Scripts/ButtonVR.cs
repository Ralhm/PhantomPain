using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sounds;
    bool isPressed; 


    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponent<AudioSource>();
        isPressed = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sounds.Play();
            isPressed = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other==presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke(); 
            isPressed = false;
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
