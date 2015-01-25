using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MatarZombie : MonoBehaviour {

	Animator anim;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Rope") {
			anim.SetBool("isDead", true);
			audio.Play();
		} 
	}

}


