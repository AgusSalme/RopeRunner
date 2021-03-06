﻿using UnityEngine;
using System.Collections;

public class GeneradorObstaculos : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1.25f;
	public float tiempoMax = 2.5f;
	public float xMin = -24;
	public float xMax = 24;
	public float y = 10;

	private float timeForNextGeneration = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeForNextGeneration -= Time.deltaTime;

		if (timeForNextGeneration <= 0) {
			Vector3 position = transform.position;
			position.x = Random.Range (xMin, xMax);
			position.y = y;
			GameObject objeto = obj [Random.Range (0, obj.Length)];
			objeto = (GameObject)Instantiate(objeto);
			objeto.transform.position = position;
			timeForNextGeneration = Random.Range(tiempoMin, tiempoMax);
		}
		//Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

	}

}
