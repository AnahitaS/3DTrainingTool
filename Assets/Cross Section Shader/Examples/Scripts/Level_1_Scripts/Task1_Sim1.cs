using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task1_Sim1 : MonoBehaviour {
	public Slider ySlider;
	public Text AnswerDisplayText;
	public Renderer rend;
	public int wheretoGo2;
	public CameraMover MyCameraMover2;
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
		ySlider.value=0.16f;
		rend.enabled = true;
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (0, 1f));
		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "Look at the 3D model.";
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "Using the slider, you only need to move the plane up to the skinniest part.";
		yield return new WaitForSeconds(1.0f);
		arrow2.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		yield return new WaitForSeconds(1.0f);
    //simulating moving plane to the skinniest part
		while (ySlider.value < 0.56f)
		{
			ySlider.value= ySlider.value + 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}

		yield return new WaitForSeconds(3.0f); 
		arrow2.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "Then check the cross-section.";
		yield return new WaitForSeconds(1.0f);
		arrow3.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		rend.enabled = false;
		yield return new WaitForSeconds(3.0f); 
		arrow3.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		AnswerDisplayText.color = Color.red;
		AnswerDisplayText.text = "And change the view to checkout the cross-section.";
		yield return new WaitForSeconds(1.0f);
		arrow4.SetActive (true);
		yield return new WaitForSeconds(1.0f);
		AnswerDisplayText.color = Color.black;
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		yield return new WaitForSeconds(5.0f); 
		arrow4.SetActive (false);
		yield return new WaitForSeconds(1.0f);

		AnswerDisplayText.text = "Need to see the process again? No worries press the [Show Answer] button.\n\nOtherwise press Go to Task 2 button to start next task.";

	}

}
