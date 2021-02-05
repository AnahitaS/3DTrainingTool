using UnityEngine;
using System.IO;
using System.Collections;
using UnityEngine.UI;

public class Score_Log : MonoBehaviour 
{
	/* This class Compute and Write socre to Score Log file for all tasks in each Level*/
	
	public void Level1_Task1_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 1 Task 1 is: " + myScore);
		writer.Close();
	}

	public void Level1_Task2_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 1 Task 2 is: " + myScore);
		writer.Close();
	}
	public void Level1_Task3_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 1 Task 3 is: " + myScore);
		writer.Close();
	}

	//---------------------------------------------------------------------------------------------
	// Level 2 Score
		public void Level2_Task1_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 2 Task 1 is: " + myScore);
		writer.Close();
	}

	public void Level2_Task2_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 2 Task 2 is: " + myScore);
		writer.Close();
	}

	//---------------------------------------------------------------------------------------------
	//Level 3 Score
	public void Level3_Task1_Score()
	{
		string path = "Assets/Study_Log_Files/Score.txt";
		string myScore;
		myScore = GameControl.control.score.ToString ();
		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Score up to level 3 Task is: " + myScore);
		writer.Close();
	}
}