using UnityEngine;
using System.Collections;

public class LoseScene : MonoBehaviour {

	public string mainGameSceneName = "Game";
	public Font font;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		GUIStyle buttonStyle = new GUIStyle ("Button");
		buttonStyle.font = font;
		Rect buttonRect = new Rect(Screen.width / 2 - 50 ,Screen.height * 3 / 4 - 25,100,50);
		if(GUI.Button(buttonRect, "Restart", buttonStyle)){
			Application.LoadLevel("Game");
		}
	}
}
