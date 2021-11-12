using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour 
{

    public GameObject Virtualbutton,go;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        go.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        go.SetActive(false);

    }
    // Use this for initialization
    void Start () {

        Virtualbutton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        Virtualbutton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        go.SetActive(false);

    }

 
}