using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Help_Level2_Task1 : MonoBehaviour {

	public Slider ySlider;
	public Slider xSlider;


	int count=0;
	public Text helpDisplayText;


	public void changeHelpText()
	{  
		//Log clicking help button


		// IF HELP is Pressed more than one time
		if (count > 0) {
			//GameControl.control.score -= 10;

			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value < -0.3))  { // 1. If in correct point but too left(x<-0.3): Move the plane to the right
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
			//---------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value > 0.2 )){ //2. If in correct point but too right (x>0.2): Move the plane to the left
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
			} // end 2
			//---------------------------------------------------------------------------------------------------------
			//Move up
			if ((ySlider.value < 0.845) && (xSlider.value > -0.3) && (xSlider.value < 0.2)) { // 3. If below correct point (y<0.845) but not too left or right: Move the plane up
				helpDisplayText.text = "Move the plane up so that it is past the branch point .";
				StartCoroutine(delay_color());
				count++;
			} // end 3
			//---------------------------------------------------------------------------------------------------------
			if ((ySlider.value < 0.845) && (xSlider.value < -0.3)) { //4.If below correct point and too left but not right: Move the plane to the right, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}


				count++;
			} // end 4
			//---------------------------------------------------------------------------------------------------------
			if ((ySlider.value < 0.845) && (xSlider.value > 0.2)) { //5. Move the plane to the left, then move the plane up 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());

				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane up so that it is past the branch point.";
					StartCoroutine(delay_color());
				}

				count++;
			} // end 5
			//---------------------------------------------------------------------------------------------------------
			//Move down

			if ((ySlider.value > 1.22) && (xSlider.value > -0.3) && (xSlider.value < 0.2)) { // 6.	If above correct point but not too left or right (y>0.845): Move the plane down
				helpDisplayText.text = "Move the plane down. Keep it above the branching point.";
				StartCoroutine(delay_color());
				count++;
			} // end 6
			//---------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 1.22) && (xSlider.value < -0.3)) { //7 If above correct point and too left but not right: Move the plane to the right, then move the plane down 
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}


				count++;
			} // end 7
			//---------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 1.22) && (xSlider.value > 0.2)) { //8. If below correct point and too right but not left: Move the plane to the left, then move the plane down  
				if (GameControl.control.viewControll == 0) {
					helpDisplayText.text = "Move the plane to the left, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 1) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == 3) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}
				//left button 0,-2,-4,-6


				if (GameControl.control.viewControll == -1) {
					helpDisplayText.text = "Move the plane to the back, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -2) {
					helpDisplayText.text = "Move the plane to the right, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}

				if (GameControl.control.viewControll == -3) {
					helpDisplayText.text = "Move the plane to the front, then move the plane down. Keep it above the branching point.";
					StartCoroutine(delay_color());
				}
				count++;
			} // end 8
			//---------------------------------------------------------------------------------------------------------
			// ALMOST Correct

			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value > -0.3) && (xSlider.value < 0.2) ) { // 9. If around correct point: You are almost there! 
				helpDisplayText.text = "Correct Answer!";
				StartCoroutine(delay_color());
				count++;
			} // end 9

		
			StartCoroutine(LateCall2());
		} // <--end of if (count==1) 

		/*----------------------------------------------------------------------------------*/
		// IF HELP is Pressed for the FIRST time
		if (count == 0) {
			//	GameControl.control.score -= 10;

			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value < -0.3)) { // 1. If in correct point but too left(x<-0.3): Move the plane to the right
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
			//-------------------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value > 0.2 )){ //2. If in correct point but too right (x>0.2): Move the plane to the left
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
			//-------------------------------------------------------------------------------------------------------------------
			//Move up
			if ((ySlider.value < 0.845) && (xSlider.value > -0.3) && (xSlider.value < 0.2)) { // 3. If below correct point (y<0.845) but not too left or right: Move the plane up
				helpDisplayText.text = "Move the plane up.";
				StartCoroutine(delay_color());
				count++;
			} // end 3
			//-------------------------------------------------------------------------------------------------------------------
			if ((ySlider.value < 0.845) && (xSlider.value < -0.3)) { //4.If below correct point and too left but not right: Move the plane to the right, then move the plane up 
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
			//-------------------------------------------------------------------------------------------------------------------
			if ((ySlider.value < 0.845) && (xSlider.value > 0.2)) { //5. Move the plane to the left, then move the plane up
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
			//-------------------------------------------------------------------------------------------------------------------
			//Move down

			if ((ySlider.value > 1.22) && (xSlider.value > -0.3) && (xSlider.value < 0.2)) { // 6.	If above correct point but not too left or right (y>1.22): Move the plane down
				helpDisplayText.text = "Move the plane down.";
				StartCoroutine(delay_color());
				count++;
			} // end 6
			//-------------------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 1.22) && (xSlider.value < -0.3)) { //7 If above correct point and too left but not right: Move the plane to the right, then move the plane down 
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
			//-------------------------------------------------------------------------------------------------------------------
			if ((ySlider.value > 1.22) && (xSlider.value > 0.2)) { //8. If below correct point and too right but not left: Move the plane to the left, then move the plane down  
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
			//-------------------------------------------------------------------------------------------------------------------
			// ALMOST Correct

			if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value > -0.3) && (xSlider.value < 0.2) ) { // 9. If around correct point: You are almost there! 
				helpDisplayText.text = "Correct Answer!";
				StartCoroutine(delay_color());
				count++;
			} // end 9
			//-------------------------------------------------------------------------------------------------------------------
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
