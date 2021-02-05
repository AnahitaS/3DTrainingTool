using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Task3_Grade_Compute : MonoBehaviour {


	public Slider ySlider;
	public Text helpDisplayText;

	public void ComputeScore_Task3_level1()
	{  
		if (((ySlider.value < 79) && (ySlider.value > 42.86)) || ((ySlider.value > 105) && (ySlider.value < 136.71))) {
			GameControl.control.score += 100;
			Application.LoadLevel ("09_Level1_Task3_Evaluate");
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
