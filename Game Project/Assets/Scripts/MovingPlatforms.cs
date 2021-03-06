﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovingPlatforms : MonoBehaviour {

public Transform Spot1;
public Transform Spot2;

private Transform towardsMe;
public float speed;
public int location = 1;
public float platformTime;

	void Start(){
		StartCoroutine(movingPlatform());		
	}
	void Update(){	
				float step = speed * Time.deltaTime;
        		transform.position = Vector3.MoveTowards(transform.position, towardsMe.position, step);
	}
	void newLocationHandler(int _location){
		location = _location;
		NewLocation();
	}
	IEnumerator movingPlatform(){
		newLocationHandler(1);
		yield return new WaitForSeconds(platformTime);
		print("once");
		newLocationHandler(2);
		yield return new WaitForSeconds(platformTime);
		StartCoroutine(movingPlatform());
	}
	void NewLocation(){
		switch (location)
		{
			case 1:
			towardsMe = Spot1;
			break;

			case 2:
			towardsMe = Spot2;
			break;
		}
	}
}
