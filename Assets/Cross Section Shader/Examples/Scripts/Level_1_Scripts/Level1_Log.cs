using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1_Log : MonoBehaviour 
{  	public Text LableText;

	public void SaveLog()
	{
		//TextWriter tw = new StreamWriter("date.txt");
		Debug.Log (LableText + "Is Preesed. "  + "Time is:" + Time.deltaTime.ToString());
	}




}