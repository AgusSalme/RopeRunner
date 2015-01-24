using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(BoxCollider other){
		if(other.tag == "Objetos"){
			GameObject Objetos = GameObject.Find("Objetos");
			Destroy(other.gameObject);
		} 
	}
}