﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FlipCharacter : MonoBehaviour {

Quaternion myRotate;

Vector3 rotValue;
	// Use this for initialization
	void Start () {
		MoveInputs.flipAction += Flip;
		rotValue.y = 90;
	}
	
	void Flip(float obj)
	{
		if(obj > 0)
			rotValue.y = 90;

		if(obj < 0)
			rotValue.y = -90;

		myRotate.eulerAngles = rotValue;
		transform.rotation = myRotate;
	}
	
}
