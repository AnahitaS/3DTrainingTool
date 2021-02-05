using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  Level3_Task_Grade_Compute: MonoBehaviour {
	public Slider xSlider;
	public Slider ySlider;
	public Slider Panel_X;
	public Slider Panel_Y;
	float timer;
	//public Text myScoreDisplayText;

	public void ComputeScore()
	{   timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);
		if (((ySlider.value > -0.02) && (ySlider.value < 0.26) && (xSlider.value >-0.1) && (xSlider.value < 0.13) && ((Panel_X.value >= 0) && (Panel_X.value < 31) || (Panel_X.value == 180))&& ((Panel_Y.value == 180) || (Panel_Y.value == 0)))){
			GameControl.control.score += 100;
			//myScoreDisplayText.text = "Your Score is: " + score.ToString ();
		}
	}
}
