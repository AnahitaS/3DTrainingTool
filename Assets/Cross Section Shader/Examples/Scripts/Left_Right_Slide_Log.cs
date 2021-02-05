using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Left_Right_Slide_Log : MonoBehaviour {

	// Use this for initialization
	public void SliderLog()
	{   
		/* Slider logged*/
		string path = "Assets/Cross Section Shader/Examples/Level1_test.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Slider_Left_Right_Changed");
		writer.Close();
	}
}
