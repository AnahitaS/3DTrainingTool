using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Set_Plane : MonoBehaviour {
	public GameObject myPlane;

	//public Transform ControlledObject;



	public Text DsiplayText;
 void Awake(){


		DsiplayText.text = myPlane.transform.position.z.ToString();
		GameControl.control.xx= myPlane.transform.position.x;

	//	XPos.value = GameControl.control.xx;
		GameControl.control.yy= myPlane.transform.position.y;
		//GameControl.displayText.text = GameControl.control.yy.ToString ();
		//YPos.value = GameControl.control.yy;

		GameControl.control.zz= myPlane.transform.position.z;
		//ZPos.value =  GameControl.control.zz;
	

	}

}
