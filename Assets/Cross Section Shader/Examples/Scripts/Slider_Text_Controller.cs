using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slider_Text_Controller : MonoBehaviour {

	public Text LRBF1;
	public Text LRBF2;
	public Slider Xslider;
	// Use this for initialization
	void Start () {
		GameControl.control.viewControll = 0;
	}
	
	// Update is called once per frame
	public void check () {
    /* new version to display text L,R,B,F in the text boxes beside slider */

		//right button 0,2,4,6
		if (GameControl.control.viewControll == 0) {
			LRBF1.text = "L";
			LRBF2.text = "R";

		}

		if (GameControl.control.viewControll == 1) {
			LRBF1.text = "F";
			LRBF2.text = "B";
		}

		if (GameControl.control.viewControll == 2) {
			LRBF1.text = "R";
			LRBF2.text = "L";
		}

		if (GameControl.control.viewControll == 3) {
			LRBF1.text = "B";
			LRBF2.text = "F";
		}
		//left button 0,-2,-4,-6
	

		if (GameControl.control.viewControll == -1) {
			LRBF1.text = "B";
			LRBF2.text = "F";
		}

		if (GameControl.control.viewControll == -2) {
			LRBF1.text = "R";
			LRBF2.text = "L";
		}

		if (GameControl.control.viewControll == -3) {
			LRBF1.text = "F";
			LRBF2.text = "B";
		}

/* This is the old version
	  if (GameControl.control.viewControll != 0) {
			viewTextDisplay.text = "In this view you can not move the plane to left or right. Consider changing your view.";
			Xslider.enabled = false;
		
		}

		else {
			Xslider.enabled = true;
			viewTextDisplay.text = "Right View. You can now move the plane to the left or right.";
	} end of old version */


} 
}