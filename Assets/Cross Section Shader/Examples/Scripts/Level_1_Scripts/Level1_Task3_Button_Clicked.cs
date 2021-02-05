using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Level1_Task3_Button_Clicked : MonoBehaviour {

	/*================================Level 1 Logs: Log all button/slider/checkbox clicks====================================*/
	/*--------------------------------*Task 3*---------------------------------------*/

	/* Help Log */
	public void Level1_Task3_Help_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3" + ", Help_Button_Pressed");
		writer.Close();
	}

	/* Complete Task Log */
	public void Level1_Task3_Complete_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", CompleteTask_Button_Pressed");
		writer.Close();
	}

	/* Slider YRotate Log*/
	public void Level1_Task3_SliderYRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Slider_YRotate_Changed");
		writer.Close();
	}

	/* Slider XRotate Log*/
	public void Level1_Task3_SliderXRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Slider_XRotate_Changed");
		writer.Close();
	}

	/* Left Button Rotate Log*/
	public void Level1_Task3_LeftRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Left_Button_Pressed");
		writer.Close();
	}

	/* Right Button Rotate Log*/
	public void Level1_Task3_RightRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Right_Button_Pressed");
		writer.Close();
	}

	/* Up Button Rotate Log*/
	public void Level1_Task3_UpRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Up_Button_Pressed");
		writer.Close();
	}

	/* Down Button Rotate Log*/
	public void Level1_Task3_DownRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Down_Button_Pressed");
		writer.Close();
	}

	/* Checked Cross-section Log*/
	public void Level1_Task3_CheckCrossSection_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", Check_CrossSection");
		writer.Close();
	}

	/* Show Answer Log*/
	public void Level1_Task3_ShowAnswer_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", ShowAnswer_Button_Pressed");
		writer.Close();
	}

	/* Next Task Log*/
	public void Level1_Task3_NextTask_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 1," + " Task 3"+ ", FinishLevel_Button_Pressed");
		writer.Close();

	}
	/*--------------------------------*End of Task 3*---------------------------------------*/
}
