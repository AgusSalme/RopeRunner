using UnityEngine;
using System.Collections;

public class LoseScene : MonoBehaviour {

	public string mainGameSceneName = "Game";
	public GUISkin buttonSkin = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		Rect buttonRect = new Rect(Screen.width / 2 - 50 ,Screen.height * 3 / 4 - 25,100,50);
		if(GUI.Button(buttonRect, "Restart", buttonSkin.button)){
			Application.LoadLevel("Game");
		}
	}
}
