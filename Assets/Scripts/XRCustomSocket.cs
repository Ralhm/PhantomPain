using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRCustomSocket : XRSocketInteractor
{
    public bool canAttach;

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        if (canAttach)
        {
            base.OnSelectEntering(args);
            print("Custom Entering!");
        }


    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (canAttach)
        {
            base.OnSelectEntered(args);
            print("Custom Entered!");
        }

    }

}
