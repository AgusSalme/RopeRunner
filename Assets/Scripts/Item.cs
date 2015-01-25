using UnityEngine;
using System.Collections;


public class Item : MonoBehaviour {

	public float velocidadDespzamiento = 0.1f;
	public bool itemgenerado = false;
	Animator anim;
	
	void Awake () {
		anim = GetComponent<Animator> ();
		}

	void FixedUpdate () {
				if (itemgenerado)
						this.transform.Translate (Vector3.down * velocidadDespzamiento);
				} else {
		itemgenerado = true;
		NotificationCenter.DefaultCenter ().PostNotification (this, "ItemSeEstanGenerando");
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
				if (other.tag == "Player") {
						NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeHaMuerto");
						GameObject Player = GameObject.Find ("Player");
						Player.SetActive (false);
				} else {
						Destroy (other.gameObject);
				}
		}
}
