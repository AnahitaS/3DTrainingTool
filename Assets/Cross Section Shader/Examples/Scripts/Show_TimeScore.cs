using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Show_TimeScore : MonoBehaviour {


	public Text current_score;
	public Text current_time;

	public void Show_Time_Score()
	{
		
		current_score.text = "Your Score is: " + GameControl.control.score.ToString ();
		current_time.text = "Your time is: " + GameControl.control.Totaltime.ToString ("00");
	}
}