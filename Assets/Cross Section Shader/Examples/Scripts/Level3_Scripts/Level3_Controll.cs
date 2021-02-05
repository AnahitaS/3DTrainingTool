using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level3_Controll : MonoBehaviour {

	public Text viewTextDisplay;
	public Slider Xslider;
	// Use this for initialization
	void Start () {
		GameControl.control.viewControll = 0;
	}

	// Update is called once per frame
	public void check () {
		if ((GameControl.control.viewControll != -6 ) && (GameControl.control.viewControll != 2 )) {
			viewTextDisplay.text = "In this view you can not move the plane to left or right. Consider changing your view.";
			Xslider.enabled = false;
		}

		else {
			Xslider.enabled = true;
			viewTextDisplay.text = "Right View. You can now move the plane to the left or right.";
		}
	}
}