using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalFeedback : MonoBehaviour {
	public Text scoreDisplayText;
	public Text timeDisplayText;
	float timer;
	public void Feedback_Task3_level1()
	{   timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);

		scoreDisplayText.text = "Your Score is: " + GameControl.control.score.ToString ();
		timeDisplayText.text = "Your Time is: " + GameControl.control.Totaltime.ToString ();
	}
}
