using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rotate_SliderX : MonoBehaviour {


	public Transform plane2;

	//public Transform ControlledObject;
  public void UpdateObjectRot( Slider myslider)
	{  
		
		Vector3 newRotation=new Vector3(plane2.rotation.x,plane2.rotation.y,plane2.rotation.z);
		//	Vector3 newRotation = new Vector3(XRot?XRot.value:0, YRot?YRot.value:0,  ZRot?ZRot.value:0);
		//	Vector3 newRotation = new Vector3(XRot?XRot.value:plane.rotation.x, YRot?YRot.value:plane.rotation.y, ZRot?ZRot.value:plane.rotation.z);


		newRotation = new Vector3(plane2.rotation.x, plane2.rotation.y+myslider.value, plane2.rotation.z);
	

		
		plane2.rotation = Quaternion.Euler(newRotation);

	}
}

