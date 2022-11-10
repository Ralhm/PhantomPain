using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerChanger : MonoBehaviour
{
    public GameObject lever;
    public GameObject ActivateObject;
    public GameObject DeactivateObject;
    public bool stationary;
    public GameObject StaionaryObject;
    bool checker;
    bool trigger; 
    public AudioSource source; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stationary)
        {
            checker = StaionaryObject.layer == 13; 
        }

        if (checker)
        {
            
        }

        if (trigger&&stationary&&checker)
        {
            if (ActivateObject != null)
            {
                Debug.Log("Hit!");
                ActivateObject.layer = 6;
            }
            if (DeactivateObject != null)
            {
                Debug.Log("Miss");
                DeactivateObject.layer = 13;
            }
        }
       



    }
    private void OnTriggerEnter(Collider other)
    {
        trigger = true;       
        if (source != null)
        {
            Debug.Log("Audio!"); 
            source.Play();
        }
        if (!stationary)
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
                    DeactivateObject.layer = 13;
                }
            }
        }


        if (stationary && checker)
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
                    DeactivateObject.layer = 13;
                }
            }
        }

        
    }


    private void OnTriggerExit(Collider other)
    {
        trigger = false;
        if (!stationary)
        {
            Debug.Log(other.name);
            if (other.name == lever.name)
            {
                if (ActivateObject != null)
                {
                    Debug.Log("LeaveHit");
                    ActivateObject.layer = 13;
                }
                if (DeactivateObject != null)
                {
                    Debug.Log("LeaveMiss");
                    DeactivateObject.layer = 6;
                }
            }

        }

        if (stationary && checker)
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
                    DeactivateObject.layer = 13;
                }
            }
        }




    }





}
