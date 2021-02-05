using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2_Task1_Sim : MonoBehaviour {
	public Slider ySlider;
	public Slider xSlider;
	public Text AnswerDisplayText;
	public Renderer rend1;
	public Renderer rend2;
	public Renderer rend3;
	public int wheretoGo2;
	public CameraMover MyCameraMover2;
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject arrow4;
	public GameObject arrow5;
	Button myButton;
	private void Start() {
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener (() => {
			StartCoroutine (startSimultaion ());
		});
	}

	private IEnumerator startSimultaion(){ // Function to simulate answers
		ySlider.value=0.16f;
		xSlider.value = -1.26f;
		rend1.enabled = true;
		rend2.enabled = true;
		rend3.enabled = true;
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (0, 1f));
		AnswerDisplayText.text = "1) Look at the 3D model.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
	    arrow1.SetActive (false);

		AnswerDisplayText.text = "2) Using the [left<->right] slider, you need to move the plane to the right.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow2.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the skinniest part
		while (xSlider.value < 0f)
		{
			xSlider.value= xSlider.value + 0.2f;
			yield return new WaitForSeconds(0.5f); 

		}
		arrow2.SetActive (false);
		yield return new WaitForSeconds(2.0f); 
		AnswerDisplayText.text = "3) Using the [Up<->Down] slider, move the plane up so that it is past the branch point.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;

		arrow3.SetActive (true);
		yield return new WaitForSeconds(2.0f);

		while (ySlider.value < 0.95f)
		{
			ySlider.value= ySlider.value + 0.2f;
			yield return new WaitForSeconds(0.5f); 

		}


		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);

		AnswerDisplayText.text = "4) Then check the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow4.SetActive (true);
		rend1.enabled = false;
		rend2.enabled = false;
		rend3.enabled = false;
		yield return new WaitForSeconds(2.0f); 
	    arrow4.SetActive (false);

		AnswerDisplayText.text = "5) And change the view to checkout the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
    	arrow5.SetActive (true);
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		yield return new WaitForSeconds(5.0f); 
		arrow5.SetActive (false);
		AnswerDisplayText.text = "Need to see the process again? No worries press the Show Answer Button.\n\nOtherwise press Go to Task 2 button to start next task.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;

	}

}
