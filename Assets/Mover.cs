using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class interactTest : MonoBehaviour {

	Selectable button;
	public CameraMover MyCameraMover;
	void OnEnable () {
		button = gameObject.GetComponent<Selectable>();
		this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(1, 1f));
	}
}
