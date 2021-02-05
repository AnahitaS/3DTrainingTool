using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

	public class ButtonController : MonoBehaviour {
		Button myButton;
	    public int wheretoGo;
	    public int ObjectType;
	    public CameraMover MyCameraMover;
		public SaveLogFile MyLogFile;
    	int countme;
		void Awake()
		{
			myButton = GetComponent<Button>(); // <-- you get access to the button component here
			myButton.onClick.AddListener(() => {MyCameraMover.StartCoroutine (this.MyCameraMover.MoveToPosition (wheretoGo, 1f)); 
			//this.MyLogFile.Mycounter(ObjectType,myButton);
			countme++;
			Debug.Log("Time Seen button" + myButton.name + " " + countme);
		} );  // <-- you assign a method to the button OnClick event here
		}
	}


