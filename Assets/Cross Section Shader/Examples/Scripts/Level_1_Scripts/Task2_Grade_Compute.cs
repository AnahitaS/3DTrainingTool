using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Task2_Grade_Compute : MonoBehaviour {
	public Toggle Answer1; 
	public Toggle Answer2;
	public Toggle Answer3;
	public Toggle Answer4;
	// Use this for initialization
	public void ComputeScore_task2_level1(){
		if(Answer3.isOn) {
			GameControl.control.score += 100;
		}
		
}
}