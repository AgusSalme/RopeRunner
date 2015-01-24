using UnityEngine;
using System.Collections;

public class GeneradorObstaculos : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1.25f;
	public float tiempoMax = 2.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
}

}
