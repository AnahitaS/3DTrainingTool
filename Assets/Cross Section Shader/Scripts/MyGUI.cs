using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyGUI : MonoBehaviour 
{
	public CameraMover MyCameraMover;
	public int count;
	public string counter;
	Selectable button;
	/*void OnGUI()
	{
		if (GUILayout.Button ("Resest To Begin")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		if (GUILayout.Button ("Move to 0")) { 
			this.MyCameraMover.StartCoroutine (this.MyCameraMover.MoveToPosition (0, 1f));
			count++;
		}
		if (GUILayout.Button ("Move to 1")) {
			this.MyCameraMover.StartCoroutine (this.MyCameraMover.MoveToPosition (1, 1f));

					
		}

		if (GUILayout.Button ("Anahita")) {
			
			this.MyCameraMover.StartCoroutine (this.MyCameraMover.MoveToPosition (1, 1f));
		}
	}*/
	// counter
	void mycounter()
	{ 
		string counter = count.ToString();
		Debug.Log("Time Seen View 0:" + counter);
	}
}
