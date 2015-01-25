using UnityEngine;
using System.Collections;

public class TornadoScript : MonoBehaviour {
	public float velocidadDespzamientoVertical = 0.03f;
	public float velocidadDespzamientoHorizontal = 0.2f;
	public float amplitudDeMovimientoHorizontal = 20;
	public float rpm = 50;
	public bool itemgenerado = false;

	private int horizontalDirection;
	private float originX;

	void Start(){
		horizontalDirection = Random.Range (0, 1) > 0.5 ? 1 : -1;
		originX = transform.position.x;
	}
		
	void FixedUpdate () {
		if (itemgenerado) {
			this.transform.Translate (Vector3.back * velocidadDespzamientoVertical, Space.World);
			this.transform.Translate (Vector3.right * velocidadDespzamientoHorizontal * horizontalDirection, Space.World);
			if(Mathf.Abs(originX - transform.position.x) > amplitudDeMovimientoHorizontal){
				horizontalDirection = -horizontalDirection;
			}
		}
		else {
			itemgenerado = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "ItemSeEstanGenerando");
		}
	}
	
	// Update is called once per frame
	void Update () {		
		transform.Rotate(Vector3.back, Time.deltaTime*rpm * 360);
		/*Quaternion rotation = transform.localRotation;
		rotation.z += velRotacion;
		transform.localRotation = rotation;
        */

	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Rope") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "SogaCortada");
			other.gameObject.SetActive (false);
		}
		else if (other.gameObject.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeHaMuerto");
			other.gameObject.SetActive (false);
		} 
	}
}
