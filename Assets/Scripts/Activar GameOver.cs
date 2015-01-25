using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject CamaraGameOver;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}

	void PersonajeHaMuerto(Notification notification){
		CamaraGameOver.SetActive(true);
	  }
		
	// Update is called once per frame
	void Update () {
	
	}
}
