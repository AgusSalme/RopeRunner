using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public float velocidadDespzamiento = 0.1f;
	public string[] collitionTags = {"Player"};
	public string loseSceneName = "Lose";

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.down * velocidadDespzamiento);
	}

	void OnTriggerEnter(Collider other) {
		foreach(string collitionTag in collitionTags){
			if(other.gameObject.tag == collitionTag){
				Application.LoadLevel(loseSceneName);
				break;
			}
		}
	}
}
