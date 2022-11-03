using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDecider : MonoBehaviour
{
    [Tooltip("True for right handed, false for left handed")]
    public bool RightHanded;

    public GameObject LeftHandRef;
    public GameObject RightHandRef;
    public FlippedHand mirrorHand;

    public void SetRight()
    {
        RightHanded = true;
        LeftHandRef.gameObject.SetActive(false);
        mirrorHand.OtherHand = RightHandRef;
    }

    public void SetLeft()
    {
        RightHanded = false;
        RightHandRef.gameObject.SetActive(false);
        mirrorHand.OtherHand = LeftHandRef;
    }
}
