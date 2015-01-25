using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	public float velocidadDespzamiento = 0.1f;
	public bool itemgenerado = false;

	void Start(){
	}

	void FixedUpdate () {
		if (itemgenerado)
			this.transform.Translate (Vector3.down * velocidadDespzamiento);
		else {
			itemgenerado = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "ItemSeEstanGenerando");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Rope") {
			//TODO Rebanar Zombie
		}
		else if (other.gameObject.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeHaMuerto");
			other.gameObject.SetActive (false);
		} 
	}
}
