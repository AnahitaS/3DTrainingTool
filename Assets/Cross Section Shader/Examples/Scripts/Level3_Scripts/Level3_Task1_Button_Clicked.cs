using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Level3_Task1_Button_Clicked : MonoBehaviour {

	/*================================Level 3 Logs====================================*/
	/*--------------------------------*Task 1*---------------------------------------*/

	/* Help Log */
	public void Level3_Task1_Help_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Help_Button_Pressed");
		writer.Close();
	}

	/* Complete Task Log */
	public void Level3_Task1_Complete_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", CompleteTask_Button_Pressed");
		writer.Close();
	}

	/* Slider Left-Right Log*/
	public void Level3_Task1_SliderLeftRight_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Slider_Left_Right_Changed");
		writer.Close();
	}

	/* Slider Up-Down Log*/
	public void Level3_Task1_SliderUpDown_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Slider_Up_Down_Changed");
		writer.Close();
	}

	/* Slider XRotate Log*/
	public void Level3_Task1_SliderXRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Slider_XRotate_Changed");
		writer.Close();
	}

	/* Slider YRotate Log*/
	public void Level3_Task1_SliderYRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Slider_YRotate_Changed");
		writer.Close();
	}

	/* Left Button Rotate Log*/
	public void Level3_Task1_LeftRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Left_Button_Pressed");
		writer.Close();
	}

	/* Right Button Rotate Log*/
	public void Level3_Task1_RightRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Right_Button_Pressed");
		writer.Close();
	}

	/* Up Button Rotate Log*/
	public void Level3_Task1_UpRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Up_Button_Pressed");
		writer.Close();
	}

	/* Down Button Rotate Log*/
	public void Level3_Task1_DownRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Down_Button_Pressed");
		writer.Close();
	}

	/* Checked Cross-section Log*/
	public void Level3_Task1_CheckCrossSection_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", Check_CrossSection");
		writer.Close();
	}

	/* Show Answer Log*/
	public void Level3_Task1_ShowAnswer_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", ShowAnswer_Button_Pressed");
		writer.Close();
	}

	/* Next Task Log*/
	public void Level3_Task1_FinishGame_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Level 3," + " Task 1" + ", FinishLevel3_Button_Pressed");
		writer.Close();
	}
	/*--------------------------------*End of Task 1*---------------------------------------*/
}
