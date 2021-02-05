using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QuizAnswerChoice : MonoBehaviour {


	public Toggle choiceToggle1; 
	public Toggle choiceToggle2;
	public Toggle choiceToggle3;
	public Toggle choiceToggle4;
	Button Done;
	int count=0;
	public Text timeRemainingDisplayText;
	public Text scoreDisplayText;

	void Awake()
	{
		Done = GetComponent<Button>(); // <-- you get access to the button component here
		Done.onClick.AddListener(() => {if((choiceToggle1.isOn) && (choiceToggle4.isOn)) {
				count=count+10;
				scoreDisplayText.text = "Score: " + count.ToString();
			}} );  // <-- you assign a method to the button OnClick event here
	}

}