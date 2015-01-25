using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int ropeLenght;
	public int levelBegin;
	public int levelEnd;
	private bool zombieMode;
	public Material ropeMaterial;
	
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
		InvokeRepeating ("ToggleLight", 10, 10);
		zombieMode = false;
	
	}
   void ToggleLight(){
		if (!zombieMode) {
			RenderSettings.ambientLight = Color.gray;
			ropeMaterial.color = Color.red;
			zombieMode = true;
		} else {
			RenderSettings.ambientLight = Color.white;
			ropeMaterial.color = Color.white;
			zombieMode = false;
		}
   }
	
	// Update is called once per frame
	void Update () {
	
	}
}
