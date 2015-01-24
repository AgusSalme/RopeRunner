using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MovieScript : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		((MovieTexture)renderer.material.mainTexture).Play ();
			
	}
		// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			audio.Stop();
			Application.LoadLevel(1);
		}

	}
}
