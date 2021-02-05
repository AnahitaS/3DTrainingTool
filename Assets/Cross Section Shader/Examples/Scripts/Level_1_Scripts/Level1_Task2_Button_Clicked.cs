using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Level1_Task2_Button_Clicked : MonoBehaviour {

	/*================================Level 1 Logs: Log all button/slider/checkbox clicks====================================*/
	/*--------------------------------*Task 2*---------------------------------------*/

	/* Help Log */
	public void Level1_Task2_Help_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Help_Button_Pressed");
		writer.Close();
	}

	/* Complete Task Log */
	public void Level1_Task2_Complete_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", CompleteTask_Button_Pressed");
		writer.Close();
	}

	/* Slider Left-Right Log*/
	public void Level1_Task2_SliderLeftRight_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Slider_Left_Right_Changed");
		writer.Close();
	}

	/* Slider Up-Down Log*/
	public void Level1_Task2_SliderUpDown_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Slider_Up_Down_Changed");
		writer.Close();
	}

	/* Left Button Rotate Log*/
	public void Level1_Task2_LeftRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Left_Button_Pressed");
		writer.Close();
	}

	/* Right Button Rotate Log*/
	public void Level1_Task2_RightRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Right_Button_Pressed");
		writer.Close();
	}

	/* Up Button Rotate Log*/
	public void Level1_Task2_UpRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Up_Button_Pressed");
		writer.Close();
	}

	/* Down Button Rotate Log*/
	public void Level1_Task2_DownRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Down_Button_Pressed");
		writer.Close();
	}

	/* Checked Cross-section Log*/
	public void Level1_Task2_CheckCrossSection_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", Check_CrossSection");
		writer.Close();
	}

	/* Show Answer Log*/
	public void Level1_Task2_ShowAnswer_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", ShowAnswer_Button_Pressed");
		writer.Close();
	}

	/* Next Task Log*/
	public void Level1_Task2_NextTask_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 2" + ", GoNextTask_Button_Pressed");
		writer.Close();

	}
	/*--------------------------------*End of Task 2*---------------------------------------*/
}
