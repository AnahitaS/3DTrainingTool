using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScreenController : MonoBehaviour {

	// Use this for initialization
	public void StartGame(){
		SceneManager.LoadScene("00_StartExample");
}
}