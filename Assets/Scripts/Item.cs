using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	
	public float velocidadDespzamiento = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector3.down * velocidadDespzamiento);
	}
}
