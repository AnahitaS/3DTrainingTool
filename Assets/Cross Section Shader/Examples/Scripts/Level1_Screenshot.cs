using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Level1_Screenshot : MonoBehaviour {

	/*================================Level 1 Logs: Log all button/slider/checkbox clicks====================================*/
	/*--------------------------------*Task 3*---------------------------------------*/

	/* Screen capture Log */
	public void Example_ScreenShot(){
		Application.CaptureScreenshot("Example_Screenshot.png");
	}

	public void Level1_Task1_ScreenShot(){
		Application.CaptureScreenshot("Level1_Task1_Screenshot.png");
	}

	public void Level1_Task2_ScreenShot(){
		Application.CaptureScreenshot("Level1_Task2_Screenshot.png");
	}

	public void Level1_Task3_ScreenShot(){
		Application.CaptureScreenshot("Level1_Task3_Screenshot.png");
	}

	public void Level2_Task1_ScreenShot(){
		Application.CaptureScreenshot ("Level2_Task1_Screenshot.png");
	}

	public void Level2_Task2_ScreenShot(){
		Application.CaptureScreenshot("Level2_Task2_Screenshot.png");
	}

	public void Level3_Task1_ScreenShot(){
		Application.CaptureScreenshot("Level3_Task1_Screenshot.png");
	}

}