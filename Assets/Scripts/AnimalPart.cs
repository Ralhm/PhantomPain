using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimalPart : MonoBehaviour
{
    public Plate plate;
    public XRSocketInteractor socket;



    public enum BodyType
    {
        Legs, Torso, Head
    }



    public BodyType Type;
    [Tooltip("Does the socket have an object attached to it?")]
    public bool Attached;
    bool CanAttach;

    private void Start()
    {
        plate = GameObject.FindObjectOfType<Plate>(); //Could also just make the plate a singleton but this works for prototype
        

        if (Type != BodyType.Head)
        {
            socket = this.gameObject.transform.GetChild(0).GetComponent<XRSocketInteractor>();
            socket.selectEntered.AddListener(delegate { SetAttached(); }); //So we don't have to manually apply the events to each and every animal prefab
            socket.selectExited.AddListener(delegate { SetUnAttached();  }); 
        }
    }


    public void SetAttached() 
    {
        print("SELECTED");
        Attached = true;
        plate.AddAnimal();

    }

    public void SetUnAttached()
    {
        print("UNSELECTED");
        Attached = false;
        plate.RemoveAnimal();
    }


    public void OnTriggerEnter(Collider other)
    {
        //print("Touched a Collider!");
        if (other.gameObject.layer == 9) //If we touch another animal part
        {
            if (Type == BodyType.Legs)
            {
                if (other.gameObject.GetComponent<AnimalPart>().Type != BodyType.Torso)
                {
                    print("Wrong body part!");
                    CanAttach = false;
                }
                else
                {
                    print("Correct!");
                    CanAttach = true;
                }
            }
            else if (Type == BodyType.Torso)
            {
                if (other.gameObject.GetComponent<AnimalPart>().Type != BodyType.Head)
                {
                    print("Wrong body part!");
                    CanAttach = false;
                }
                else
                {
                    print("Correct!");
                    CanAttach = true;
                }
            }

            
        }
    }

}
