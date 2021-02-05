using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UI;
public class ShowTask : MonoBehaviour {
	public Text task_Instrcutions;
	// Use this for initialization

	
	// Update is called once per frame
	public void toggle_change ( bool newValue) {
		task_Instrcutions.enabled=newValue;
	}
}
