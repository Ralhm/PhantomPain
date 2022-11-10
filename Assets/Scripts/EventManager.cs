using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject WhiteBoardSet;
    public GameObject AnimalSet;
    public GameObject TutorialSet;
    public GameObject ActualTutorialObj;
    public Transform plateLocation; //Where the plate ends up when we move on from animal assembly
    public Plate plate;


    // Start is called before the first frame update
    void Start()
    {
        ActualTutorialObj.gameObject.SetActive(false);
    }



    public IEnumerator WhiteBoardEaseIn(float x) //let x represent the final position
    {
        plate.gameObject.transform.position = plateLocation.position;
        plate.SetRotating();

        for (int i = 0; i < 50; i++)
        {
            AnimalSet.transform.position += new Vector3(0, -6.0f - AnimalSet.transform.position.y, 0) * 0.05f;


            WhiteBoardSet.transform.position += new Vector3(x - WhiteBoardSet.transform.position.x, 0, 0) * 0.1f;
            yield return null;
            if (WhiteBoardSet.transform.position.x > x)
            {
                break;
            }
        }
    }

    public IEnumerator TutorialEaseIn(float y) //let x represent the final position
    {
        ActualTutorialObj.gameObject.SetActive(true);
        for (int i = 0; i < 100; i++)
        {

            WhiteBoardSet.transform.position += new Vector3(0, -8 - WhiteBoardSet.transform.position.y, 0) * 0.05f;

            TutorialSet.transform.position += new Vector3(0, y - TutorialSet.transform.position.y, 0) * 0.1f;
            yield return null;
            if (TutorialSet.transform.position.y < y)
            {
                break;
            }
        }
    }

}
