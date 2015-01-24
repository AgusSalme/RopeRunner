using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public float velocidadDespzamiento = 0.1f;
	public string[] collitionTags = {"Player"};
	public Camera loseCamera;
	public Camera inGameCamera;
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.back * velocidadDespzamiento);
	}

	void OnTriggerEnter(Collider other) {
		if (inGameCamera.enabled){
			foreach(string collitionTag in collitionTags){
				if(other.gameObject.tag == collitionTag){
					loseCamera.enabled = true;
					inGameCamera.enabled = false;
					break;
				}
			}
		}
	}
}
