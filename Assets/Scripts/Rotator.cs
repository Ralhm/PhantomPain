using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 RotationSpeed;


    // Update is called once per frame
    void FixedUpdate()
    {
        Rotate();
    }


    void Rotate()
    {
        transform.Rotate(RotationSpeed);
    }
}
