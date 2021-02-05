using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Level3_Help : MonoBehaviour {

	public Slider ySlider; //moving
	public Slider xSlider;
	public Slider Panel_X; //rotating
	public Slider Panel_Y; 


	int count=0;
	public Text helpDisplayText;


	public void changeHelpText()
	{  
		//Log clicking help button


		// IF HELP is Pressed more than one time
		if (count > 0) {
			//if wrong view
			if ((GameControl.control.viewControll == 0) || (GameControl.control.viewControll == 2) || (GameControl.control.viewControll == -2)) {
				if (((ySlider.value > -0.02) && (ySlider.value < 0.26) && (xSlider.value > -0.1) && (xSlider.value < 0.13) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180)) && ((Panel_Y.value == 180) || (Panel_Y.value == 0)))) {

					helpDisplayText.text = "Correct Answer!";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value > -0.02) && (ySlider.value < 0.26) && ((xSlider.value < -0.1) || (xSlider.value > 0.13)) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180)) && ((Panel_Y.value == 180) || (Panel_Y.value == 0))) {
					helpDisplayText.text = "Move the plane close to the center of the object.\n\n Also, you may want to change the view to rotate the object and see the hole.";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value > -0.02) && (ySlider.value < 0.26) && ((xSlider.value < -0.1) || (xSlider.value > 0.13))) {
					helpDisplayText.text = "Move the plane close to the center of the object, and rotate the plane so that it is perpendicular to the hole.\n\nAlso, you may want to change the view to rotate the object and see the hole.";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value < -0.02) && (ySlider.value < 0.26)) {
					helpDisplayText.text = "Move the plane up close to the center of the object.\n\nAlso, you may want to change the view to rotate the object and see the hole.";
					StartCoroutine(delay_color());
					count++;

				} else if ((ySlider.value > 0.26)) {
					helpDisplayText.text = "Move the plane down close to the center of the object.\n\nAlso, you may want to change the view to rotate the object and see the hole.";
					StartCoroutine(delay_color());
					count++;

				} else {
					helpDisplayText.text = "Rotate the plane so that it is perpendicular to the hole.\n\nAlso, you may want to change the view to rotate the object and see the hole.";
					StartCoroutine(delay_color());
					count++;
				}
			}

			//if right view
			else {
				if (((ySlider.value > -0.02) && (ySlider.value < 0.26) && (xSlider.value > -0.1) && (xSlider.value < 0.13) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180)) && ((Panel_Y.value == 180) || (Panel_Y.value == 0)))) {

					helpDisplayText.text = "Correct Answer!";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value > -0.02) && (ySlider.value < 0.26) && ((xSlider.value < -0.1) || (xSlider.value > 0.13)) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180)) && ((Panel_Y.value == 180) || (Panel_Y.value == 0))) {
					helpDisplayText.text = "Move the plane close to the center of the object.\n\nFeel free to change the view to rotate the object, if necessary.";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value > -0.02) && (ySlider.value < 0.26) && ((xSlider.value < -0.1) || (xSlider.value > 0.13))) {
					helpDisplayText.text = "Move the plane close to the center of the object, and rotate the plane so that it is perpendicular to the hole.\n\nFeel free to change the view to rotate the object, if necessary.";
					StartCoroutine(delay_color());
					count++;
				} else if ((ySlider.value < -0.02)) {
					helpDisplayText.text = "Move the plane up close to the center of the object.\n\nFeel free to change the view to rotate the object, if necessary.";
					StartCoroutine(delay_color());
					count++;

				} else if ((ySlider.value > 0.26)) {
					helpDisplayText.text = "Move the plane down close to the center of the object.\n\nFeel free to change the view to rotate the object, if necessary.";
					StartCoroutine(delay_color());
					count++;

				} else {
					helpDisplayText.text = "Rotate the plane so that it is perpendicular to the hole.\n\nFeel free to change the view to rotate the object, if necessary.";
					StartCoroutine(delay_color());
					count++;
				}
			}
			StartCoroutine(LateCall2());
		} // <--end of if (count==1) 

		/*----------------------------------------------------------------------------------*/
		// IF HELP is Pressed for the FIRST time
		if (count < 2 ) {
			//	GameControl.control.score -= 10;

			if (((ySlider.value > -0.02) && (ySlider.value < 0.26) && (xSlider.value >-0.1) && (xSlider.value < 0.13) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180))&& ((Panel_Y.value == 180) || (Panel_Y.value == 0)))){
				
				helpDisplayText.text = "Correct Answer!";
				StartCoroutine(delay_color());
				count++;
			} 

			else if ((GameControl.control.viewControll == 0) || (GameControl.control.viewControll ==2) || (GameControl.control.viewControll ==-2)){
				helpDisplayText.text = "You should move the plane and rotate it.\n\nAlso, you may want to change the view to rotate the object and see the hole.";
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
