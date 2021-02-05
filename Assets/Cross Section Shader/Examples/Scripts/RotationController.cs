using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotationController : MonoBehaviour {

	  public Slider XRot;
    public Slider YRot;
    public Slider ZRot;

  
    //public Transform ControlledObject;
	public void UpdateObjectPosition(Transform ControlledObject)
	{  

		Vector3 newRotation = new Vector3(XRot?XRot.value:0, YRot?YRot.value:0,  ZRot?ZRot.value:0);
	//	Vector3 newRotation = new Vector3(XRot?XRot.value:plane.rotation.x, YRot?YRot.value:plane.rotation.y, ZRot?ZRot.value:plane.rotation.z);


		//Vector3 newRotation = new Vector3(XRot?XRot.value+plane.rotation.x:0, YRot?YRot.value+plane.rotation.y:0, ZRot?ZRot.value+plane.rotation.z:0);
	//	Vector3 newRotation = new Vector3(0,0,0);
		ControlledObject.rotation = Quaternion.Euler(newRotation);

    }
}
