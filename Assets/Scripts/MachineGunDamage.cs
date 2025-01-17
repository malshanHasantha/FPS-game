﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunDamage : MonoBehaviour
{
    int DamageAmount = 3;
	float AllowedRangemp5k = 30;

	public Camera fpsCam;
	RaycastHit bullet;
	[SerializeField] GameObject bullethole;
	

	void Update (){
		RaycastHit Hit;
		if(Input.GetMouseButton(0) && ammoCollect1.ammoLoadMP5K >0){
			if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRangemp5k)){
				if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out bullet)){
						Instantiate(bullethole,bullet.point,Quaternion.LookRotation(Vector3.up,bullet.normal));
					}
				if(Hit.transform.tag == "enemy"){
					Hit.transform.SendMessage("deductPoints",DamageAmount);	
				}
			}
		}
	}
}
