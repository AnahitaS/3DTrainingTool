using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ParticipantIDSave : MonoBehaviour {

	public InputField partID;
	// Use this for initialization
	public void SaveParticipantID(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine("Participant ID: " + partID.text);
		writer.WriteLine("Time" + ",Page" + ",Task" + ",Action");
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Training," + " Page" + ", StartTraining_Button_Pressed");
		writer.Close();	


		string path2 = "Assets/Study_Log_Files/Score.txt";
		//Write some text to the test.txt file
		StreamWriter writer2 = new StreamWriter(path2, true);
		writer2.WriteLine("Participant ID: " + partID.text);
		writer2.Close();
	}
}
