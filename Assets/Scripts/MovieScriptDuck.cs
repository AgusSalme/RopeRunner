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
			otherPlane.SetActive (true);
			Invoke("DestroyDuck", 0.1f);
		}
		void DestroyDuck(){
			Destroy (this.gameObject);
		}
		
		// Update is called once per frame
		void Update () {

			
		}

}
