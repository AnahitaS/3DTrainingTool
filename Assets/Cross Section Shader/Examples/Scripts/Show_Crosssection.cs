using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UI;

public class Show_Crosssection : MonoBehaviour {

	public GameObject my_Object;
	// Use this for initialization


	// Update is called once per frame
	public void toggle_Coross_change ( bool newValue) {
		my_Object.SetActive(!newValue);
	}
}