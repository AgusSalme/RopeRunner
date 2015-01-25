using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MovieScriptDuck : MonoBehaviour {
		public GameObject otherPlane;
		// Use this for initialization
		void Start()
		{
			((MovieTexture)renderer.material.mainTexture).Play ();
			Invoke("PlaySound", 1);
			Invoke("ChangePlane", 5);
		}

		void PlaySound(){
			audio.Play();
		}

		void ChangePlane(){
			Destroy (this.gameObject);
			otherPlane.SetActive (true);
		}
		
		// Update is called once per frame
		void Update () {

			
		}

}
