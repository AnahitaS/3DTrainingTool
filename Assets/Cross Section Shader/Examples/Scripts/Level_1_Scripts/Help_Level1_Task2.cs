using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Help_Level1_Task2 : MonoBehaviour {

	public Slider ySlider;
	public Slider xSlider;

	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject arrow4;
	public GameObject arrow5;
	public GameObject arrow6;

	int count=0;
	public Text helpDisplayText;


	public void changeHelpText()
	{   
		//Log clicking help button

		/*=============================================================================================*/
		// IF HELP is Pressed more than one time
		if (count > 0 && (GameControl.control.downControll==0)) {
			//GameControl.control.score -= 10;

			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value < 0.34)) { // 1. If in correct point but too left: Move the plane to the right
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6
			
				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 1
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value > 0.44 )){ //2. If in correct point but too right: Move the plane to the left
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

			
				count++;
			} // end 2
			//-----------------------------------------------------------------------------------------
			//Move up
			if ((ySlider.value < -0.05) && (xSlider.value > 0.34) && (xSlider.value < 0.44)) { // 3. If below correct point (y<0.51) but not too left or right: Move the plane up
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));

				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 3
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value < -0.05) && (xSlider.value < 0.34)) { //4.If below correct point and too left but not right: Move the plane to the right, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 4
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value < -0.05) && (xSlider.value > 0.44)) { //5. Move the plane to the left, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));

				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 5
			//-----------------------------------------------------------------------------------------
			//Move down

			if ((ySlider.value > 0.63) && (xSlider.value > 0.34) && (xSlider.value < 0.44)) { // 6.	If above correct point but not too left or right : Move the plane down

				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				count++;
			} // end 6
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > 0.63) && (xSlider.value < 0.34)) { //7 If above correct point and too left but not right: Move the plane to the right, then move the plane down
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 7
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > 0.63) && (xSlider.value > 0.44)) { //8. If above correct point and too right but not left: Move the plane to the left, then move the plane down
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
					arrow1.SetActive (true);
					arrow2.SetActive (true);
					StartCoroutine(LateCall2(arrow1, arrow2));
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
					arrow5.SetActive (true);
					arrow6.SetActive (true);
					StartCoroutine(LateCall2(arrow5, arrow6));
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
					arrow3.SetActive (true);
					arrow4.SetActive (true);
					StartCoroutine(LateCall2(arrow3, arrow4));
				}

				count++;
			} // end 8
			//-----------------------------------------------------------------------------------------
			// ALMOST Correct

			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value > 0.34) && (xSlider.value < 0.44) ) { // 8. If around correct point: You are almost there! 
				helpDisplayText.text = "Correct Answer!";
				StartCoroutine(delay_color());
			
				count++;
			} // end 1



		} // <--end of if (count==1) 

		/*===============================================================================================*/
		// IF HELP is Pressed for the FIRST time
		else {
			//	GameControl.control.score -= 10;

			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value < 0.34)) { // 1. If in correct point but too left: Move the plane to the right
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
				}

				count++;
			} // end 1
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value > 0.44 )){ //2. If in correct point but too right: Move the plane to the left
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left.";
					StartCoroutine(delay_color());

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front.";
					StartCoroutine(delay_color());
				}
				count++;
			} // end 2
			//-----------------------------------------------------------------------------------------
			//Move up
			if ((ySlider.value < -0.05) && (xSlider.value > 0.34) && (xSlider.value < 0.44)) { // 3. If below correct point  but not too left or right: Move the plane up
				helpDisplayText.text = "Move the plane up.";
				StartCoroutine(delay_color());
				count++;
			} // end 3
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value < -0.05) && (xSlider.value < 0.34)) { //4.If below correct point and too left but not right: Move the plane to the right, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
				}

				count++;
			} // end 4
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value < -0.05) && (xSlider.value > 0.44)) { //5. Move the plane to the left, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up.";
					StartCoroutine(delay_color());

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up.";
					StartCoroutine(delay_color());
				}

				count++;
			} // end 5

		
			//-----------------------------------------------------------------------------------------
			//Move up
			if ((ySlider.value > 0.63) && (xSlider.value > 0.34) && (xSlider.value < 0.44)) { // 6.	If above correct point but not too left or right : Move the plane down
				helpDisplayText.text = "Move the plane down.";
				StartCoroutine(delay_color());
				count++;
			} // end 6
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > 0.63) && (xSlider.value < 0.34)) { //7 If above correct point and too left but not right: Move the plane to the right, then move the plane down 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
				}
				count++;
			} // end 7
			//-----------------------------------------------------------------------------------------
			if ((ySlider.value > 0.63) && (xSlider.value > 0.44)) { //8. If above correct point and too right but not left: Move the plane to the left, then move the plane down  
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down.";
					StartCoroutine(delay_color());
				}
				count++;
			} // end 8
			//-----------------------------------------------------------------------------------------
			// ALMOST Correct

			if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (xSlider.value > 0.34) && (xSlider.value < 0.44) ) { // 8. If around correct point: You are almost there! 
				helpDisplayText.text = "Correct Answer!";
				StartCoroutine(delay_color());
				count++;
			} // end 1
			StartCoroutine(LateCall2(arrow1,arrow2));
		} // <--end of if (count==0) 
	} // <-end ofchangetext()

	private IEnumerator LateCall2(GameObject arrowX, GameObject arrowY) {
		yield return new WaitForSeconds(5.0f);    // and now we wait !
		arrowX.SetActive (false);
		arrowY.SetActive (false);   
		helpDisplayText.text = "If you need more help, press [Help] button again.";
		StartCoroutine(delay_color());
	}

	private IEnumerator delay_color() {
		helpDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
	}
}

