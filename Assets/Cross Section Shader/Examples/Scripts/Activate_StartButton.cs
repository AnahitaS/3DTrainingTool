using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Activate_StartButton : MonoBehaviour {

	public InputField partID;
	public Button myButton;

	string myText;
	// Lets activate the start button by type "P"
	public void StringStart(){
		myText = partID.text;
		if (myText == "CHI_2019")
			myButton.interactable = true;
}


}