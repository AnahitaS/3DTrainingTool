using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class helpMe_Level1_Task3 : MonoBehaviour {

	public Slider ySlider;

	int count=0;
	public Text helpDisplayText;


	public void changeHelpText()
	{  
		// IF HELP is Pressed more than one time
		if (count > 0) {
			//GameControl.control.score -= 10;

			if ((ySlider.value > 79) && (ySlider.value < 105)) { // 1.	if not in correct point-- close to horizontal (y>79 && y< 105): Rotate the plane so it is not close to horizontal
				helpDisplayText.text = "Rotate the plane so it is not close to horizontal.";
				StartCoroutine(delay_color());
				count++;
			} // end 1

		
			if ((ySlider.value > 136.71) || (ySlider.value < 42.86) ) { // 2. If not in correct point ( y<42.86 || y>136.71): Rotate The plane so it is not close to vertical
				helpDisplayText.text = "Rotate The plane so it is not close to vertical";
				StartCoroutine(delay_color());
				count++;
			} // end 2

			// ALMOST Correct
			if (((ySlider.value < 79) && (ySlider.value > 42.86)) || ((ySlider.value > 105) && (ySlider.value < 136.71)) ) { // 3. If around correct point: You are almost there! [  42.86 <y<136.71] && [ y<79 && y> 105)]
				helpDisplayText.text = "Correct Answer.";
				StartCoroutine(delay_color());
				count++;
			} // end 3

		 StartCoroutine(LateCall2());
		} // <--end of if (count==1) 

		/*----------------------------------------------------------------------------------*/
		// IF HELP is Pressed for the FIRST time
		if (count == 0) {
			//GameControl.control.score -= 10;

			if (((ySlider.value > 79) && (ySlider.value < 105)) || (ySlider.value > 136.71) && (ySlider.value < 42.86)) { // 1.	If not in correct point (y>79 && y< 105 II y<42.86 || y>136.71): Rotate The plane
				helpDisplayText.text = "Rotate the plane.";
				StartCoroutine(delay_color());
				count++;
			} // end 1


			// ALMOST Correct
			if (((ySlider.value < 79) && (ySlider.value > 42.86)) || ((ySlider.value > 105) && (ySlider.value < 136.71))) { // 2. If around correct point: You are almost there! [  42.86 <y<136.71] && [ y<79 && y> 105)]
				helpDisplayText.text = "Correct Answer.";
				StartCoroutine(delay_color());
				count++;
			} // end 2

			StartCoroutine(LateCall2());
		} // <--end of if (count==0) 


	} // <-end ofchangetext()

	private IEnumerator LateCall2() {
		yield return new WaitForSeconds(5.0f);    // and now we wait !
		helpDisplayText.text = "If you need more help, press [Help] button again.";
		StartCoroutine(delay_color());
	}

	private IEnumerator delay_color() {
		helpDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
	}
}
