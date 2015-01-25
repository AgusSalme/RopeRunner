using UnityEngine;
using System.Collections;

public class ItemArbol : MonoBehaviour {

	public float velocidadDespzamiento = 0.1f;
	public bool itemgenerado = false;
	
	
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
		if (other.tag == "Rope") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "SogaCortada");
			GameObject Player = GameObject.Find ("Rope");
			Player.SetActive (false);
		} else {
			Destroy (other.gameObject);
		}
	}
}
