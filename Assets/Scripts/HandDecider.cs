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
    public FlippedHand mirrorHandRight;
    public FlippedHand mirrorHandLeft;

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
        mirrorHandRight.OtherHand = RightHandRef;
        mirrorHandRight.gameObject.SetActive(true);

    }

    public void SetLeft()
    {
        ActivateObjects();
        RightHanded = false;
        RightHandRef.gameObject.SetActive(false);
        mirrorHandLeft.OtherHand = LeftHandRef;
        mirrorHandLeft.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        mirrorHandLeft.gameObject.SetActive(true);
        //mirrorHand.transform.

    }

    public void ActivateObjects()
    {
        
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        LeftButtonRef.gameObject.SetActive(false);
        RightButtonRef.gameObject.SetActive(false);
    }

}
