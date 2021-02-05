using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Leve1_Task2_Garde_compute : MonoBehaviour {


	public Slider zSlider;
	public Slider ySlider;
	float timer;
	public Text helpDisplayText;
	//public Text myScoreDisplayText;

	public void ComputeScore()
	{   timer += Time.deltaTime;
		GameControl.control.Totaltime = (timer % 60);
		if ((ySlider.value > -0.05) && (ySlider.value < 0.63) && (zSlider.value > 0.34) && (zSlider.value < 0.44)) {
			GameControl.control.score += 100;
			Application.LoadLevel ("07_Level1_Task2_Evaluate");
			GameControl.control.downControll = 0;
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

