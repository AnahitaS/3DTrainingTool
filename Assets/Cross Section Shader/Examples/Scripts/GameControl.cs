using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour {

	public static GameControl control;

	public int score=0;
	public float Totaltime=0;
	public float xx;
	public float yy;
	public float zz;
	public int viewControll;
	public int downControll; 
	public Text participantID;

	// Use this for initialization
	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
