using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public int ropeLenght;
	public int levelBegin;
	public int levelEnd;
	public string loseSceneName = "Lose";
	
	public static GameManager gamemanager;
	
	void Awake (){
		if (gamemanager == null) {
				gamemanager = this;
				DontDestroyOnLoad (gameObject);
		}
		else if (gamemanager != this) 
		{
				Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");
		NotificationCenter.DefaultCenter ().AddObserver (this, "SogaCortada");
   }

	void PersonajeHaMuerto(){	
		GameOver ();
	}

	void GameOver(){		
		Application.LoadLevel (loseSceneName);
	}

	void SogaCortada(){		
		Invoke ("GameOver", 1);
	}

	// Update is called once per frame
	void Update() { 
		if (Input.GetKey(KeyCode.Escape)) { Application.Quit(); }
	}
}
