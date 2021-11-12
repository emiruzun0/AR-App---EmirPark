using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public GameObject light1,light2;

	
	public void pressedButton () {
        light1.SetActive(!light1.activeSelf);
        light2.SetActive(!light2.activeSelf);
       
    }

}
