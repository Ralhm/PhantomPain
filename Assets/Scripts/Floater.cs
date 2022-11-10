using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public float frequency;
    public float magnitude;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = pos + Vector3.forward * Mathf.Sin(Time.time * frequency) * magnitude;

    }
}
