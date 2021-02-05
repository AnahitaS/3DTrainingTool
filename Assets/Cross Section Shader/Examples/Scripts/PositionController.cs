using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PositionController : MonoBehaviour {

    public Slider XPos;
    public Slider YPos;
    public Slider ZPos;
    //public Transform ControlledObject;

	public Text helpDisplayText;


    public void UpdateObjectPosition(Transform ControlledObject)
    {   

	//	Vector3 newPosition = new Vector3(XPos?XPos.value:GameControl.control.xx, YPos?YPos.value:GameControl.control.yy, ZPos?ZPos.value:GameControl.control.zz);
		Vector3 newPosition = new Vector3(XPos?XPos.value:0, YPos?YPos.value:0, ZPos?ZPos.value:0);
	 //  helpDisplayText.text = GameControl.control.zz.ToString ();
		ControlledObject.localPosition = newPosition;
    }
}
