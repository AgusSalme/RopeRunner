using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int ropeLenght;
	public int levelBegin;
	public int levelEnd;
	
	public static GameManager gamemanager;
	
	void Awake (){
			if (gamemanager == null) {
					gamemanager = this;
					DontDestroyOnLoad (gameObject);
			} else if (gamemanager != this) {
					Destroy (gameObject);
			}
		}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
