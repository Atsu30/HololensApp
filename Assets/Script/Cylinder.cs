using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Cylinder : MonoBehaviour, IFocusable
{
    public Material focusOn;
    public Material focusOut;

    public void OnFocusEnter()
    {
        GetComponent<Renderer>().material = focusOn;
    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material = focusOut;
    }
}
