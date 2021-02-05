using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{	IEnumerator RotateMe(Vector3 byAngles, float inTime) 
	{    var fromAngle = transform.rotation;
		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
		for(var t = 0f; t < 1; t += Time.deltaTime/inTime) {
			transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
			yield return null;
		}
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			StartCoroutine(RotateMe(Vector3.right * 90, 0.8f));
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			StartCoroutine(RotateMe(Vector3.right * -90, 0.8f));
		}
	}
}
