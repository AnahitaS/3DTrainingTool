using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task3_Sim1 : MonoBehaviour {
	public Slider ySliderR;
	public Slider xSliderR;
	public Text AnswerDisplayTextR;
	public Renderer rendR;
	public int wheretoGo2R;
	public CameraMover MyCameraMover2R;
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
		ySliderR.value=90;
		xSliderR.value=90;
		rendR.enabled = true;
		MyCameraMover2R.StartCoroutine (this.MyCameraMover2R.MoveToPosition (0, 1f));
		AnswerDisplayTextR.text = "Look at the 3D model.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(3.0f);
		arrow1.SetActive (false);


		AnswerDisplayTextR.text = "You only need to rotate the plane so it is not close to horizontal or vertical. You should use the vertical slider for that.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow2.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating rotating the plane 
		while (ySliderR.value < 119)
		{
			ySliderR.value= ySliderR.value + 10;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(3.0f); 
		arrow2.SetActive (false);

		AnswerDisplayTextR.text = "Then check the cross-section.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow3.SetActive (true);
		rendR.enabled = false;
		yield return new WaitForSeconds(3.0f); 
		arrow3.SetActive (false);

		AnswerDisplayTextR.text = "And you can change the view and checkout the cross-section.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow4.SetActive (true);
		MyCameraMover2R.StartCoroutine (this.MyCameraMover2R.MoveToPosition (wheretoGo2R, 1f));
		yield return new WaitForSeconds(4.0f); 
		arrow4.SetActive (false);

		AnswerDisplayTextR.text = "It is optional but you can use the horizontal slider to rotate the plane from another angel.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow5.SetActive (true);
		rendR.enabled = true;
		yield return new WaitForSeconds(1.0f);
		MyCameraMover2R.StartCoroutine (this.MyCameraMover2R.MoveToPosition (0, 1f));
		yield return new WaitForSeconds(2.0f);
		//simulating rotating the plane 
		while (xSliderR.value > 0)
		{
			xSliderR.value= xSliderR.value - 20;
			yield return new WaitForSeconds(0.5f); 

		}

		yield return new WaitForSeconds(3.0f); 
		arrow5.SetActive (false);

		AnswerDisplayTextR.text = "Then check the cross-section.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow3.SetActive (true);
		rendR.enabled = false;
		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);

		AnswerDisplayTextR.text = "And you can change the view and checkout the cross-section.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
		arrow4.SetActive (true);
		MyCameraMover2R.StartCoroutine (this.MyCameraMover2R.MoveToPosition (wheretoGo2R, 1f));
		yield return new WaitForSeconds(5.0f); 
		arrow4.SetActive (false);
		AnswerDisplayTextR.text = "Need to see the process again? No worries, press the Show Answer Button.";
		AnswerDisplayTextR.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayTextR.color = Color.black;
	}

}
