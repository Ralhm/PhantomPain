using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerChanger : MonoBehaviour
{
    public GameObject lever;
    public GameObject ActivateObject;
    public GameObject DeactivateObject; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == lever.name)
        {
            if (ActivateObject != null)
            {
                Debug.Log("Hit!"); 
                ActivateObject.layer = 6; 
            }
            if (DeactivateObject != null)
            {
                Debug.Log("Miss");
                DeactivateObject.layer = 1;
            }
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == lever.name)
        {
            if (ActivateObject != null)
            {
                Debug.Log("LeaveHit");
                ActivateObject.layer = 1;
            }
            if (DeactivateObject != null)
            {
                Debug.Log("LeaveMiss");
                DeactivateObject.layer = 6;
            }
        }

    }

}
