using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example_Sim : MonoBehaviour {
	public Slider ySlider;
	public Slider xSlider;
	public Slider Panel_X;
	public Slider Panel_Y;
	public Text AnswerDisplayText;
	public Renderer rend;
	public int wheretoGo2;
	public CameraMover MyCameraMover2;
	public GameObject MycameraGroup;
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject arrow4;
	public GameObject arrow5;
	public GameObject arrow6;
	public GameObject arrow7;
	public GameObject arrow8;
	public GameObject arrow9;
	Button myButton;
	public GameObject target;
	public Text LRBF1;
	public Text LRBF2;
	private void Start() {
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener (() => {
			StartCoroutine (startSimultaion ());
		});
	}

	private IEnumerator startSimultaion(){ // Function to simulate answers
		ySlider.value=0.16f;
		rend.enabled = true;
		/* Look at 3D Model */
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (0, 1f));
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "1. Look at the 3D model.";
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		/* Move Up and Down */
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "2. Using the [Up<->Down] slider, you can move the plane up or down.";
		yield return new WaitForSeconds(1.0f);
		arrow2.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		//move up
		while (ySlider.value < 0.6f)
		{
			ySlider.value= ySlider.value + 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}
		//move down
		while (ySlider.value > 0.3f)
		{
			ySlider.value= ySlider.value - 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(1.0f); 
		arrow2.SetActive (false);
		yield return new WaitForSeconds(1.0f);
		//======================================================
		/* Move left and right */
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "3. Using the [Left<->Right] slider, you can move the plane to the left or right.";
		yield return new WaitForSeconds(1.0f);
		arrow3.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		//move right
		yield return new WaitForSeconds(2.0f);
		while (xSlider.value < -0.1f)
		{
			xSlider.value= xSlider.value + 0.3f;
			yield return new WaitForSeconds(0.5f); 

		}
		xSlider.value= xSlider.value - 0.1f;
		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);
		yield return new WaitForSeconds(1.0f);
		//================================================================
		/* Rotate Using First Slider*/
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "4. Rotate the plane using the Rotation sliders.";
		yield return new WaitForSeconds(1.0f);
		arrow4.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		//simulatingRotation
		while (Panel_X.value >= 60)
		{
			Panel_X.value= Panel_X.value - 10;
			yield return new WaitForSeconds(0.5f); 

		}
		while (Panel_X.value < 80)
		{
			Panel_X.value= Panel_X.value + 10;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(2.0f); 
		arrow4.SetActive (false);
		yield return new WaitForSeconds(1.0f);
		/*---------------------------------------------*/
		/* Rotate Using Second Slider*/
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "5. Rotate the plane using the second slider.";
		yield return new WaitForSeconds(1.0f);
		arrow5.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		//simulating Rotation
		while (Panel_Y.value < 130)
		{
			Panel_Y.value= Panel_Y.value + 10;
			yield return new WaitForSeconds(0.5f); 

		}
		while (Panel_Y.value > 100)
		{
			Panel_Y.value= Panel_Y.value - 10;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(2.0f); 
		arrow5.SetActive (false);
		yield return new WaitForSeconds(1.0f);
		/*---------------------------------------------*/
		//===================================================
		//Change the Left/Right view
		yield return new WaitForSeconds(1.0f); 
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "6. Use left/right rotation buttons to rotate the objects to the left or right.";
		yield return new WaitForSeconds(1.0f);
		arrow6.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		MycameraGroup.transform.RotateAround (target.transform.position, Vector3.up, 90f);
		LRBF1.text = "F";
		LRBF2.text = "B";
		yield return new WaitForSeconds(1.0f); 
		AnswerDisplayText.color = Color.red;
		yield return new WaitForSeconds(1.0f);
		arrow6.SetActive (false);

		AnswerDisplayText.color = Color.red;
		yield return new WaitForSeconds(1.0f);
		arrow7.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
		MycameraGroup.transform.RotateAround (target.transform.position, Vector3.up, -90f);
		LRBF1.text = "L";
		LRBF2.text = "R";
		yield return new WaitForSeconds(1.0f); 
		arrow7.SetActive (false);

		AnswerDisplayText.color = Color.red;
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.text = "Then check the cross-section.";
		yield return new WaitForSeconds(1.0f);
		arrow8.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		rend.enabled = false;
		yield return new WaitForSeconds(1.0f); 
		arrow8.SetActive (false);
		yield return new WaitForSeconds(1.0f);


		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "And change the view to checkout the cross-section.";
		yield return new WaitForSeconds(1.0f);
		arrow9.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		yield return new WaitForSeconds(1.0f); 
		arrow9.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		AnswerDisplayText.text = "Need to see the process again? No worries press the Show Answer Button.\n\nOtherwise press [Finish Example] button to start main training.";

	}

}
