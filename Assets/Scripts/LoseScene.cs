﻿using UnityEngine;
using System.Collections;

public class LoseScene : MonoBehaviour {

	public string mainGameSceneName = "Game";
	public GUISkin buttonSkin = null;

	// Use this for initialization
	void Start () {
		GameManager.gamemanager.StopInvokePoints();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		Rect buttonRect = new Rect(Screen.width / 2 - 50 ,Screen.height * 3 / 4 - 25,100,50);
		if(GUI.Button(buttonRect, "" ,buttonSkin.button)){
			AdministradorPuntos adminPuntos = GameManager.gamemanager.GetComponent<AdministradorPuntos>();
			adminPuntos.puntuacion = 0;
			Application.LoadLevel("Game");
			adminPuntos.StartInvokingPoints();

		}
	}
}
