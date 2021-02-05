using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UI;

public class Idle_Arrow_help : MonoBehaviour {

	public GameObject arrow1;
	public GameObject arrow2;
	// Use this for initialization

	float maxIdleTime = 10;
	float timeCount = 0;
    Vector3 lastMousePos= Vector3.zero;


	void Update() {
	/*	if(lastMousePos == Input.mousePosition) {
			timeCount += Time.deltaTime;
			if(timeCount > maxIdleTime) {
				arrow1.SetActive (true);
				arrow2.SetActive (true);
				timeCount = 0;
			}
		} else
			timeCount = 0;

		lastMousePos = Input.mousePosition;*/
	}

}