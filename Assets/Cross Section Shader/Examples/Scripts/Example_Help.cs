using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Example_Help : MonoBehaviour {



	public Text helpDisplayText;


	public void changeHelpText()
	{  	// IF HELP is Pressed 
	      helpDisplayText.color = Color.red;
		  helpDisplayText.text = "You should both move the plane and rotate it.";
		  StartCoroutine(delay());
		  StartCoroutine(LateCall2());
		} 


	private IEnumerator LateCall2() {
		yield return new WaitForSeconds(6.0f);    // and now we wait !
		helpDisplayText.color = Color.red;
		helpDisplayText.text = "If you need more help, press [Help] button again.";
		yield return new WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
	}

	private IEnumerator delay() {
		yield return new  WaitForSeconds(2.0f);
		helpDisplayText.color = Color.black;
	}
}