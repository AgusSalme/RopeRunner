using UnityEngine;
using System.Collections;

public class MovieScript : MonoBehaviour {

	// Use this for initialization

	public MovieTexture movTexture;

	void Start() {
		((MovieTexture)renderer.material.mainTexture).Play();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			Application.LoadLevel(1);
		}

	}
}
