using UnityEngine;
using System.Collections;

public class AdministradorPuntos : MonoBehaviour {

	public int puntosGanados = 5;
	public int puntuacion;
	public TextMesh marcador;
	public TextMesh marcador2;


	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		InvokeRepeating ("IncrementarPuntos",0.2f,0.2f);
	// Invoca el metodo "IncrementarPuntos" en 1 segundo y cada 1 segundos
	
	}

	void IncrementarPuntos(){
		//Metodo que le suma a la puntuacion actual los puntos ganados
		puntuacion+=puntosGanados;
		ActualizarMarcador(); 
	}

	void ActualizarMarcador(){
		if(marcador)marcador.text = puntuacion.ToString();
	}

	// Update is called once per frame
	void Update () {
	
	}

}
