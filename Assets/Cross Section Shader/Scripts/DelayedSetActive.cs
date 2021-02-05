using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DelayedSetActive : MonoBehaviour {
	public Button myButton;
	private void Start() {
		//myButton = GetComponent<Button>();
		//if (myButton.gameObject.activeInHierarchy)
		myButton.interactable=false;
		StartCoroutine(LateCall());
		}
	private IEnumerator LateCall() {
		yield return new WaitForSeconds(2.0f);    // and now we wait !
		myButton.interactable=true;     // enable the object

	}
}