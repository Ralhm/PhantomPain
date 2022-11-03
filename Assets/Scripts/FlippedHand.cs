using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippedHand : MonoBehaviour
{
    public GameObject OtherHand;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-OtherHand.transform.position.x, OtherHand.transform.position.y, OtherHand.transform.position.z);
        transform.rotation = Quaternion.Inverse(OtherHand.transform.rotation);
        

    }

    void FixedUpdate()
    {


    }
}
