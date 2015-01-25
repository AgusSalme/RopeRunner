using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int ropeLenght;
	public int levelBegin;
	public int levelEnd;
	private bool zombieMode;
	public Material ropeMaterial;
	public GameObject light1;
	public GameObject light2;
	public GameObject light3;
	public int zombieTime = 10;
	
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
		InvokeRepeating ("ToggleLight", zombieTime, zombieTime);
		zombieMode = false;
		ropeMaterial.color = Color.white;	
	}
   void ToggleLight(){
		if (!zombieMode) {
			RenderSettings.ambientLight = Color.gray;
			ropeMaterial.color = Color.red;
			light1.GetComponent<Light>().enabled = true;
			light2.GetComponent<Light>().enabled = true;
			light3.GetComponent<Light>().enabled = true;
			zombieMode = true;
		} else {
			RenderSettings.ambientLight = Color.white;
			ropeMaterial.color = Color.white;	
			light1.GetComponent<Light>().enabled = false;
			light2.GetComponent<Light>().enabled = false;
			light3.GetComponent<Light>().enabled = false;
			zombieMode = false;
		}
   }
	
	// Update is called once per frame
	void Update () {
	
	}
}
