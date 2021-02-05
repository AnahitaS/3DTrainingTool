using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Grade_Compute : MonoBehaviour {


	public Slider zSlider;
	public Slider ySlider;
	float timer;
	public Text helpDisplayText;
	//public Text myScoreDisplayText;

	public void ComputeScore()
	{
		timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);
		if ((ySlider.value > 0.51) && (ySlider.value < 0.58) && (zSlider.value > -0.7) && (zSlider.value < 0.71)) {
			GameControl.control.score += 100;
			Application.LoadLevel ("05_Level1_Task1_Evaluate");
			GameControl.control.downControll = 0;
			//myScoreDisplayText.text = "Your Score is: " + score.ToString ();
		} else {
			
			helpDisplayText.text = "Please try one more time to find the correct answer. You can read the task instructions carefully and use the [Help] button if needed.";
			StartCoroutine(delay_color());
		}
	}

	private IEnumerator delay_color() {
		helpDisplayText.color = Color.red;
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.text = "If you need more help, press [Help] button again.";
	}
}

