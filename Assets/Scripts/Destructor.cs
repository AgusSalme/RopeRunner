using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		Debug.Log("Destruir");
	}

	void OnCollisionEnter(Collision other){
		Destroy(other.gameObject);
		Debug.Log ("Destruir");
	}
}