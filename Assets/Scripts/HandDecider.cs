using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDecider : MonoBehaviour
{
    [Tooltip("True for right handed, false for left handed")]
    public bool RightHanded;

    public GameObject LeftHandRef;
    public GameObject RightHandRef;
    public GameObject RightButtonRef;
    public GameObject LeftButtonRef;
    public GameObject nextButton;
    public GameObject backButton;
    public FlippedHand mirrorHand;

    void Awake()
    {
        nextButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
    }

    public void SetRight()
    {
        ActivateObjects();
        RightHanded = true;
        LeftHandRef.gameObject.SetActive(false);
        mirrorHand.OtherHand = RightHandRef;

    }

    public void SetLeft()
    {
        ActivateObjects();
        RightHanded = false;
        RightHandRef.gameObject.SetActive(false);
        mirrorHand.OtherHand = LeftHandRef;
        //mirrorHand.transform.

    }

    public void ActivateObjects()
    {
        mirrorHand.gameObject.SetActive(true);
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        LeftButtonRef.gameObject.SetActive(false);
        RightButtonRef.gameObject.SetActive(false);
    }

}
