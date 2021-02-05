using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Level3_Sim : MonoBehaviour {
	public Slider ySlider;
	public Slider xSlider;
	public Slider Panel_X;
	public Slider Panel_Y;
	public Text AnswerDisplayText;
	public Renderer rend1;

	public int wheretoGo;
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



	public GameObject target;
	public Text LRBF1;
	public Text LRBF2;

	Button myButton;
	private void Start() {
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener (() => {
			StartCoroutine (startSimultaion ());
		});
	}

	private IEnumerator startSimultaion(){ // Function to simulate answers
		ySlider.value= -0.7f;
		xSlider.value = 0.7f;
		//Panel_Y.value= 110;
		//Panel_X.value = 90;
		rend1.enabled = true;
	
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo, 1f));
		AnswerDisplayText.text = "1. Look at the 3D model.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow1.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		arrow1.SetActive (false);

		AnswerDisplayText.text = "2. You cannot see the hole from this view. But at first let's move the plane to the right.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow2.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		while (xSlider.value > 0.0f)
		{
			xSlider.value= xSlider.value - 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}
	//	xSlider.value= xSlider.value - 0.1f;
		arrow2.SetActive (false);
		yield return new WaitForSeconds(2.0f); 

		AnswerDisplayText.text = "3. Now Let's change the view to rotate the object and see the hole.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow3.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		MycameraGroup.transform.RotateAround (target.transform.position, Vector3.up, 90f);
		LRBF1.text = "F";
		LRBF2.text = "B";
		yield return new WaitForSeconds(2.0f); 
		arrow3.SetActive (false);

		AnswerDisplayText.text = "4. Move the plane up so that it is close to center of the object.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow4.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the skinniest part
		while (ySlider.value < 0.10f)
		{
			ySlider.value= ySlider.value + 0.1f;
			yield return new WaitForSeconds(0.5f); 

		}
		//ySlider.value= ySlider.value - 0.10f;
		yield return new WaitForSeconds(2.0f); 
		arrow4.SetActive (false);

		AnswerDisplayText.text = "5. Rotate the plane using the first slider.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow5.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the skinniest part
		while (Panel_Y.value != 0)
		{
			Panel_Y.value= Panel_Y.value - 20;
			yield return new WaitForSeconds(0.5f); 

		}
		arrow5.SetActive (false);
		yield return new WaitForSeconds(2.0f); 

		AnswerDisplayText.text = "4. Rotate the plane using the second slider.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow6.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		//simulating moving plane to the skinniest part
		while (Panel_X.value != 0)
		{
			Panel_X.value= Panel_X.value - 20;
			yield return new WaitForSeconds(0.5f); 

		}
		arrow6.SetActive (false);
		yield return new WaitForSeconds(1.0f); 

		AnswerDisplayText.text = "5. Then check the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow7.SetActive (true);
		rend1.enabled = false;
		yield return new WaitForSeconds(2.0f); 
		arrow7.SetActive (false);

		AnswerDisplayText.text = "Can we be more accurate? Let’s check the object from top view)";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow8.SetActive (true);
		yield return new WaitForSeconds(2.0f); 
		rend1.enabled = true;
		yield return new WaitForSeconds(2.0f);
		arrow8.SetActive (false);
		//AnswerDisplayText.text = "And change the view to checkout the cross-section.";

		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo2, 1f));
		AnswerDisplayText.text = "1. To place the plane through the fattest part of the object, we need to slightly rotate it.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow6.SetActive (true);
		yield return new WaitForSeconds(2.0f); 
		while (Panel_X.value != 20)
		{
			Panel_X.value= Panel_X.value + 5;
			yield return new WaitForSeconds(0.5f); 

		}
		arrow6.SetActive (false);
		yield return new WaitForSeconds(2.0f); 

		AnswerDisplayText.text = "2. Again check the cross-section.";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow7.SetActive (true);
		rend1.enabled = false;
		yield return new WaitForSeconds(2.0f);
		arrow7.SetActive (false);

		AnswerDisplayText.text = "3. And change the view to see the cross-section";
		AnswerDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		AnswerDisplayText.color = Color.black;
		arrow8.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		MyCameraMover2.StartCoroutine (this.MyCameraMover2.MoveToPosition (wheretoGo, 1f));
		yield return new WaitForSeconds(5.0f); 
	    arrow8.SetActive (false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//AnswerDisplayText.text = "Need to see the process again? No worries press the Show Answer Button.\n\nOtherwise press Go to Task 2 button to start next task.";


	}

}
