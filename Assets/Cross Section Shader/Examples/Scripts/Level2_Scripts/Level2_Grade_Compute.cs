using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2_Grade_Compute : MonoBehaviour {
	public Slider xSlider;
	public Slider ySlider;
	float timer;
	public Text helpDisplayText;
	//public Text myScoreDisplayText;

	public void ComputeScore()
	{   timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);
		if ((ySlider.value > 0.845) && (ySlider.value < 1.22) && (xSlider.value > -0.3) && (xSlider.value < 0.2) ) {
			GameControl.control.score += 100;
			Application.LoadLevel ("12_Level2_Task1_Evaluate");
			GameControl.control.downControll = 0;
			//myScoreDisplayText.text = "Your Score is: " + score.ToString ();
		}

		else {
			
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
