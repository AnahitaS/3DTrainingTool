using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Level2_task2_Sim : MonoBehaviour {
	public Slider ySlider;
	public Slider xSlider;
	public Slider Panel_X;
	public Slider Panel_Y;
	public Text AnswerDisplayText;
	public Renderer rend1;
	public Renderer rend2;
	public Renderer rend3;
	public int wheretoGo;
	public int wheretoGo2;
	public CameraMover MyCameraMover2;
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject arrow4;
	public GameObject arrow5;
	public GameObject arrow6;
	public GameObject arrow7;
	Button myButton;
	private void Start() {
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener (() => {
			StartCoroutine (startSimultaion ());
		});
	}

	private IEnumerator startSimultaion(){ // Function to simulate answers
		ySlider.value=0.16f;
		xSlider.value = -1.25f;
		Panel_Y.value= 110;
	//	Panel_X.value = 90;
		rend1.enabled = true;
		rend2.enabled = true;
		rend3.enabled = true;
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo, 1f));

		AnswerDisplayText.text = "1. Look at the 3D model.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (false);

		AnswerDisplayText.text = "2. Use the [Left<->Right] slider to move the plane to the right to cut the 3D model.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow2.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		while (xSlider.value < -0.1f)
		{
			xSlider.value= xSlider.value + 0.3f;
			yield return new WaitForSeconds(0.5f); 

		}
		xSlider.value= xSlider.value - 0.1f;
		yield return new WaitForSeconds(2.0f); 
		arrow2.SetActive (false);

		AnswerDisplayText.text = "3. Use the [Up<->Down] slider to move the plane up so that it is a bit past the branch point.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow3.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the branching point
		while (ySlider.value < 0.60f)
		{
			ySlider.value= ySlider.value + 0.2f;
			yield return new WaitForSeconds(0.5f); 

		}
		ySlider.value= ySlider.value - 0.10f;
		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);

		AnswerDisplayText.text = "4. Rotate the plane using the first slider.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow4.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulatingRotation
		while (Panel_X.value >= 10)
		{
			Panel_X.value= Panel_X.value - 10;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(2.0f); 
		arrow4.SetActive (false);

		AnswerDisplayText.text = "5. Rotate the plane using the second slider.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow5.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating Rotation
		while (Panel_Y.value < 130)
		{
			Panel_Y.value= Panel_Y.value + 10;
			yield return new WaitForSeconds(0.5f); 

		}
		yield return new WaitForSeconds(2.0f); 
		arrow5.SetActive (false);

		AnswerDisplayText.text = "6. Then check the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
        arrow6.SetActive (true);
		rend1.enabled = false;
		rend2.enabled = false;
		rend3.enabled = false;
		yield return new WaitForSeconds(2.0f); 
		arrow6.SetActive (false);

		AnswerDisplayText.text = "7. And change the view to checkout the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
	    arrow7.SetActive (true);
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		yield return new WaitForSeconds(5.0f); 
		arrow7.SetActive (false);

		//load the secne instead of the message
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//AnswerDisplayText.text = "Need to see the process again? No worries press the Show Answer Button.\n\nOtherwise press Go to Task 2 button to start next task.";


	}

}
