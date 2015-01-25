using UnityEngine;
using System.Collections;

public class MarcadorFinal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UpdateFinalScore ();
	}
	void UpdateFinalScore(){
		Debug.Log("Funciona");
		this.GetComponent<TextMesh> ().text = GameManager.gamemanager.GetComponent<AdministradorPuntos> ().puntuacion.ToString();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
