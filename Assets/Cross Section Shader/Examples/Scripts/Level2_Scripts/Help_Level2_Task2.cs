using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Help_Level2_Task2 : MonoBehaviour {

	public Slider ySlider; //moving
	public Slider xSlider;
	public Slider Panel_X; //rotating
	public Slider Panel_Y; 


	int count=0;
	public Text helpDisplayText;


	public void changeHelpText()
	{  //Log clicking help button
		
		// IF HELP is Pressed more than one time
		if (count > 0) {
			//GameControl.control.score -= 10;

			if (((ySlider.value > 0.73) && (ySlider.value < 0.90) && (xSlider.value > 0.23) && (xSlider.value < 0.4) && (Panel_X.value > 117) && (Panel_X.value < 141) && (Panel_Y.value > 125) && (Panel_Y.value < 141))
			    || ((ySlider.value > 0.49) && (ySlider.value < 0.81) && (xSlider.value > -0.21) && (xSlider.value <= 0.0) && (Panel_X.value >= 0.0) && (Panel_X.value < 5.0) && (Panel_Y.value > 129) && (Panel_Y.value < 151))) { // 1. If in correct point but too left(x<-0.3): Move the plane to the right
				helpDisplayText.text = "Correct Answer.";
				StartCoroutine(delay_color());
				count++;
			} else if ((ySlider.value > 0.5) && (ySlider.value < 0.7)) {
				helpDisplayText.text = "Rotate and/or move the plane to cover both one branch and the trunk.";
				StartCoroutine(delay_color());
				count++;
			} else if ((ySlider.value < 0.5)) {
				helpDisplayText.text = "Move the plane up to where the branches start, then rotate it to cover both one branch and the trunk.";
				StartCoroutine(delay_color());
				count++;

			} else {
				helpDisplayText.text = "Move the plane to where the branches start, then rotate it to cover both one branch and the trunk.";
				StartCoroutine(delay_color());
				count++;
			}
			StartCoroutine(LateCall2());
		} // <--end of if (count==1) 

		/*----------------------------------------------------------------------------------*/
		// IF HELP is Pressed for the FIRST time
		if (count == 0) {
			//	GameControl.control.score -= 10;

			if (((ySlider.value > 0.73) && (ySlider.value < 0.90) && (xSlider.value > 0.23) && (xSlider.value < 0.4) && (Panel_X.value > 117) && (Panel_X.value < 141) && (Panel_Y.value > 125) && (Panel_Y.value < 141))
				|| ((ySlider.value > 0.49) && (ySlider.value < 0.81) && (xSlider.value >= -0.21) && (xSlider.value <= 0.0) && (Panel_X.value >= 0.0) && (Panel_X.value < 5.0) && (Panel_Y.value > 129) && (Panel_Y.value < 151))) { // 1. If in correct point but too left(x<-0.3): Move the plane to the right
				helpDisplayText.text = "Correct Answer.";
				StartCoroutine(delay_color());
				count++;
			} 

			else {
				helpDisplayText.text = "You should both move the plane and rotate it.";
				StartCoroutine(delay_color());
				count++;
			}
			StartCoroutine(LateCall2());
		} // <--end of if (count==0) 
	} // <-end ofchangetext()

	private IEnumerator LateCall2() {
		yield return new WaitForSeconds(6.0f);    // and now we wait !

		helpDisplayText.text = "If you need more help, press [Help] button again.";
		StartCoroutine(delay_color());
	}

	private IEnumerator delay_color() {
		helpDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
	}
}
