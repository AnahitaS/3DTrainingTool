using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveLogFile : MonoBehaviour 
{   Button Finished;
	string counter;
	int count=0;

	public void Mycounter(int ObjectType, Button myButton)
	{
		if (ObjectType == 1) {
			count++;
		}
	}

	void Awake()
		{
		Finished = GetComponent<Button>(); // <-- you get access to the button component here
		Finished.onClick.AddListener(() => {counter = count.ToString();
			Debug.Log("Button Anahita Has been clicked:" + counter + "times");} );  // <-- you assign a method to the button OnClick event here
	}



}