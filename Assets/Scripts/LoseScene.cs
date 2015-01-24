using UnityEngine;
using System.Collections;

public class LoseScene : MonoBehaviour {

	public string mainGameSceneName = "Game";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		if(GUI.Button(new Rect(Screen.width / 2 - 50 ,Screen.height * 3 / 4 - 25,100,50), "Restart")){
			Application.LoadLevel("Game");
		}
	}
}
