using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    bool FullAnimal;
    public bool Rotating;
    public int rotationSpeed;
    public int animalParts = 0;



    // Update is called once per frame
    void Update()
    {
        if (Rotating)
        {
            Rotate();
        }
    }

    public void AddAnimal()
    {
        animalParts++;
        if (animalParts == 3)
        {
            FullAnimal = true;
        }
    }

    public void RemoveAnimal()
    {
        animalParts--;
        FullAnimal = false;
    }

    public void SetRotating()
    {
        Rotating = true;
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * rotationSpeed);
    }

}
