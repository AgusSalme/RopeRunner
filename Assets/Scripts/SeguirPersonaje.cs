using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion = 6f;
	public float separaciony = 15f;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(personaje.position.x+separacion, personaje.position.y+separaciony, transform.position.z);
	}
}
