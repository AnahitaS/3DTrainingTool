using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  Level2_task2_Grade_Compute: MonoBehaviour {
	public Slider xSlider;
	public Slider ySlider;
	public Slider Panel_X;
	public Slider Panel_Y;
	float timer;
	//public Text myScoreDisplayText;

	public void ComputeScore()
	{   timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);
		if (((ySlider.value > 0.73) && (ySlider.value < 0.90) && (xSlider.value > 0.23) && (xSlider.value < 0.4) && (Panel_X.value > 117) && (Panel_X.value < 141) && (Panel_Y.value > 125) && (Panel_Y.value < 141))
			|| ((ySlider.value > 0.49) && (ySlider.value < 0.81) && (xSlider.value > -0.21) && (xSlider.value <= 0.0) && (Panel_X.value >= 0.0) && (Panel_X.value < 5.0) && (Panel_Y.value > 129) && (Panel_Y.value < 151))) {
			GameControl.control.score += 100;
			//myScoreDisplayText.text = "Your Score is: " + score.ToString ();
		}
	}
}

