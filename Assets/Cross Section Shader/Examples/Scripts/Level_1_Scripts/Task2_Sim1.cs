using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task2_Sim1 : MonoBehaviour {
	public Slider xSlider;
	public Text AnswerDisplayText;
	public Renderer rend;
	public int wheretoGo2;
	public GameObject target;
	public Transform mycamerajoon;

	public Text LRBF1;
	public Text LRBF2;

//	public CameraMover MyCameraMover2;
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject arrow4;
	Button myButton;
	private void Start() {
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener (() => {
			StartCoroutine (startSimultaion ());
		});
	}

	private IEnumerator startSimultaion(){ // Function to simulate answers
		xSlider.value=-0.16f;
		rend.enabled = true;
	//	MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (0, 1f));


		AnswerDisplayText.text = "Look at the 3D model.";
		StartCoroutine(delay_color());
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (false);
		AnswerDisplayText.text = "Using the [Left<->Right] slider, you only need to move the plane to the right and to the fattest part.";
		StartCoroutine(delay_color());
		yield return new WaitForSeconds(1.0f);
		arrow2.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the skinniest part
		while (xSlider.value < 0.34f)
		{
			xSlider.value= xSlider.value + 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}

		yield return new WaitForSeconds(2.0f); 
		arrow2.SetActive (false);
		yield return new  WaitForSeconds(1.0f);
		AnswerDisplayText.text = "Then check the cross-section.";
		StartCoroutine(delay_color());
		yield return new WaitForSeconds(1.0f);
		arrow3.SetActive (true);
		rend.enabled = false;

		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);
		AnswerDisplayText.text = "And change the view to checkout the cross-section.";
		StartCoroutine(delay_color());
		yield return new WaitForSeconds(1.0f);
		arrow4.SetActive (true);
		mycamerajoon.transform.RotateAround (target.transform.position, Vector3.up, 90f);
		LRBF1.text = "F";
		LRBF2.text = "B";
		//MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		yield return new WaitForSeconds(5.0f); 
		arrow4.SetActive (false);
		mycamerajoon.transform.RotateAround (target.transform.position, Vector3.up, -90f);
		LRBF1.text = "L";
		LRBF2.text = "R";
		rend.enabled = true;
		AnswerDisplayText.text = "Need to see the process again? No worries press the [Show Answer] button.\n\nOtherwise press Go to Task 3 button to start next task.";
		StartCoroutine(delay_color());

	}

	private IEnumerator delay_color() {
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		yield return new  WaitForSeconds(1.0f);
	}

}
