using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rotate_SliderY : MonoBehaviour {


	public Transform plane3;

	//public Transform ControlledObject;
	public void UpdateObjectRot( Slider myslider)
	{  

		Vector3 newRotation=new Vector3(plane3.rotation.x,plane3.rotation.y,plane3.rotation.z);
		//	Vector3 newRotation = new Vector3(XRot?XRot.value:0, YRot?YRot.value:0,  ZRot?ZRot.value:0);
		//	Vector3 newRotation = new Vector3(XRot?XRot.value:plane.rotation.x, YRot?YRot.value:plane.rotation.y, ZRot?ZRot.value:plane.rotation.z);


		newRotation = new Vector3(myslider.value, plane3.rotation.y, plane3.rotation.z);



		plane3.rotation = Quaternion.Euler(newRotation);

	}
}

