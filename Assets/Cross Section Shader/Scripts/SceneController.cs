using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

	// Use this for initialization
		public void ChangeScene(string sceneName)
		{
		Application.LoadLevel(sceneName);
		GameControl.control.downControll = 0;
		}
	}