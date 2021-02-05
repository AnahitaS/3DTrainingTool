using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Exmple_Button_Log_Click : MonoBehaviour {
	/*================================Example====================================*/
	/*--------------------------------*Example*---------------------------------------*/


	/* Example Starts */
	public void Example_StartExample_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Training_to_Example_Page" + ", StartExample_Button_Pressed");
		writer.Close();
	}

	/* Help Log */
	public void Example_Task_Help_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Help_Button_Pressed");
		writer.Close();
	}


	/* Complete Task Log */
	public void Example_Task_Complete_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", CompleteTask_Button_Pressed");
		writer.Close();
	}

	/* Slider Left-Right Log*/
	public void Example_Task_SliderLeftRight_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Slider_Left_Right_Changed");
		writer.Close();
	}

	/* Slider Up-Down Log*/
	public void Example_Task_SliderUpDown_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Slider_Up_Down_Changed");
		writer.Close();
	}

	/* Slider XRotate Log*/
	public void  Example_Task_SliderXRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Slider_XRotate_Changed");
		writer.Close();
	}

	/* Slider YRotate Log*/
	public void  Example_Task_SliderYRotate_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Slider_YRotate_Changed");
		writer.Close();
	}

	/* Left Button Rotate Log*/
	public void Example_Task_LeftRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Left_Button_Pressed" );
		writer.Close();
	}

	/* Right Button Rotate Log*/
	public void Example_Task_RightRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Right_Button_Pressed");
		writer.Close();
	}

	/* Up Button Rotate Log*/
	public void Example_Task_UpRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Up_Button_Pressed");
		writer.Close();
	}

	/* Down Button Rotate Log*/
	public void Example_Task_DownRotateButton_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Down_Button_Pressed");
		writer.Close();
	}

	/* Checked Cross-section Log*/
	public void Example_Task_CheckCrossSection_Log()
	{   
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", Check_CrossSection");
		writer.Close();
	}

	/* Show Answer Log*/
	public void Example_Task_ShowAnswer_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", ShowAnswer_Button_Pressed");
		writer.Close();
	}

	/* Next Task Log*/
	public void Example_Task_FinishExample_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Example," + " Task" + ", FinishExample_Button_Pressed");
		writer.Close();

	}

	/* Start Level 1*/
	public void Example_Task_StartLevel1_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Example_To_Level1_Page" + ", StartLevel1_Button_Pressed");
		writer.Close();

	}

	/* Repeat Example*/
	public void Example_Task_RepeatExample_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Example_To_Level1_Page" + ", RepeatExample_Button_Pressed");
		writer.Close();

	}

	/* Start Level 2*/
	public void Example_Task_StartLevel2_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Level1_To_Level2_Page" + ", StartLevel2_Button_Pressed");
		writer.Close();

	}

	/* Repeat Level1*/
	public void Example_Task_RepeatLevel1_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + "Level1_To_Level2_Page" + ", RepeatLevel1_Button_Pressed");
		writer.Close();

	}

	/* Start Level 3*/
	public void Example_Task_StartLevel3_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Level2_To_Level3_Page" + ", StartLevel3_Button_Pressed");
		writer.Close();

	}

	/* Repeat Level2*/
	public void Example_Task_RepeatLevel2_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Level2_To_Level3_Page" + ", RepeatLevel2_Button_Pressed");
		writer.Close();

	}

	/* Quit App*/
	public void Quit_App_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Final_Page" + ", FinishTraining_Button_Pressed");
		writer.Close();

	}

	/* Repeat Level3*/
	public void Quit_AppRepeatLevel3_log(){
		string path = "Assets/Study_Log_Files/Study_AllClicks_Log.txt";
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ", Transition," + " Final_page" + ", RepeatLevel3_Button_Pressed");
		writer.Close();

	}
	/*--------------------------------*End of Task*---------------------------------------*/
}
