using UnityEngine;
using System.Collections;

public class Marcador : MonoBehaviour {

	public int puntuacion = 0;
 	public TextMesh marcador;
	public TextMesh marcador2;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		ActualizarMarcador();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
		marcador2.text = puntuacion.ToString ();
	}
}

