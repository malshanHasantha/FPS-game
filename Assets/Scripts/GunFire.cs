﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	public AudioSource gunsound;

	void Update () {
		if(Input.GetMouseButtonDown(1)){
			gunsound.Play();
			GetComponent<Animation>().Play();
			
		}
	}
}