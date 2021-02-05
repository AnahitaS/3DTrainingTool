using UnityEngine;
using System.IO;
using System.Collections;
using UnityEngine.UI;
public class Left_button_Rotate : MonoBehaviour

{	/*IEnumerator RotateMe(Vector3 byAngles, float inTime) 
	{    var fromAngle = transform.rotation;
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
	}


void Update()
{


}*/
/*public void ButtonInteract(){
 StartCoroutine (RotateMe (Vector3.up * 45, 0.8f));
		//transform.Rotate(Vector3.up* 90, 0.8f, Space.World);
		//RotationController.Slider_control.XRot.value = RotationController.Slider_control.XRot.value + 45;
		//RotationController.Slider_control.YRot.value = RotationController.Slider_control.YRot.value + 45;
		//RotationController.Slider_control.ZRot.value = RotationController.Slider_control.ZRot.value + 45;
	}*/
public Transform target2;
//private Vector3 point;



public void ButtonInteract(){
	//point = target.transform.position;//get target's coords


	/*Transfrom Object*/
	transform.RotateAround (target2.transform.position, Vector3.up, -90f);
	if (GameControl.control.viewControll == -3)	GameControl.control.viewControll = 0;
	else GameControl.control.viewControll = GameControl.control.viewControll - 1;
	//transform.RotateAround (Vector3.zero, Vector3.right, -90f);


}

}