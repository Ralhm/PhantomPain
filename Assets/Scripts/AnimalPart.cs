using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimalPart : MonoBehaviour
{

    public enum BodyType
    {
        Legs, Torso, Head
    }

    

    public BodyType Type;
    [Tooltip("Does the socket have an object attached to it?")]
    public bool Attached;
    bool CanAttach;


    public void SetAttached() 
    {
        print("SELECTED");
        Attached = true;


    }

    public void SetUnAttached()
    {
        print("UNSELECTED");
        Attached = false;

    }

    public void SetSelected()
    {

    }

    public void UnSelected()
    {

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
