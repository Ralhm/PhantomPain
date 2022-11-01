using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDecider : MonoBehaviour
{
    [Tooltip("True for right handed, false for left handed")]
    public bool RightHanded;


    public void SetRight()
    {
        RightHanded = true;
    }

    public void SetLeft()
    {
        RightHanded = false;
    }
}
