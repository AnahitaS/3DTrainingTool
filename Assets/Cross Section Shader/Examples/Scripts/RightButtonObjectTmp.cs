using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButtonObjectTmp : MonoBehaviour {
 
	//public Transform plane2;
	IEnumerator RotateMe(Vector3 byAngles, float inTime) 
	{   var fromAngle = transform.rotation;
		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
		for(var t = 0f; t < 1; t += Time.deltaTime/inTime) {
			transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
			yield return null;
		}
	}
	//	void Update () {

	//		StartCoroutine (RotateMe (Vector3.up * -90, 0.8f));

	//}

	/*	void Awake()
	{
		myButton = GetComponent<Button>(); // <-- you get access to the button component here
		myButton.onClick.AddListener(() => {Update();
		} );  // <-- you assign a method to the button OnClick event here
	} //ad */



	public void ButtonInteract() {
		StartCoroutine (RotateMe (Vector3.up * -90, 0.8f));

	}

}