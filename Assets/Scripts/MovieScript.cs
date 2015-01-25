using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MovieScript : MonoBehaviour {

	public int goToScene = 1;
	public TextMesh spacebartext;
	private bool spacebar;
	// Use this for initialization
	void Start()
	{
		spacebar = false;
		((MovieTexture)renderer.material.mainTexture).Play ();
		if(spacebartext)Invoke ("EnableSpaceBar", 4);

	}

	void EnableSpaceBar(){
		spacebar = true;
		spacebartext.text = "Press Space to continue";
	
	}
		// Update is called once per frame
	void Update () {
		if (spacebar && Input.GetKeyUp(KeyCode.Space)) {
			audio.Stop();
			Application.LoadLevel(goToScene);
		}

	}
}
