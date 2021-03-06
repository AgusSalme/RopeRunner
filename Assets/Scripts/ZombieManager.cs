﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ZombieManager : MonoBehaviour {

	private bool zombieMode;
	public Material ropeMaterial;
	public Light light1;
	public Light light2;
	public Light light3;
	public GeneradorObstaculos[] generadores;
	public GeneradorObstaculos generadorDeZombies;
	
	public int zombieTime = 10;
	private List<Light> lights;
	// Use this for initialization
	void Start () {
		zombieMode = false;
		ropeMaterial.color = Color.white;
		InvokeRepeating ("ToggleLight", zombieTime, zombieTime);
	}

	void ToggleLight(){
		if (!zombieMode) {
			RenderSettings.ambientLight = Color.gray;
			ropeMaterial.color = Color.red;
			light1.enabled = true;
			light2.enabled = true;
			light3.enabled = true;
			zombieMode = true;
			foreach(GeneradorObstaculos generador in generadores){
				generador.enabled = false;
			}
			generadorDeZombies.enabled = true;
		} else {
			RenderSettings.ambientLight = Color.white;
			ropeMaterial.color = Color.white;	
			light1.enabled = false;
			light2.enabled = false;
			light3.enabled = false;
			foreach(GeneradorObstaculos generador in generadores){
				generador.enabled = true;
			}
			generadorDeZombies.enabled = false;
			zombieMode = false;
		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
