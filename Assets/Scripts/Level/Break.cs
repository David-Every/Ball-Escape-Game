﻿using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {

		
	void OnCollisionEnter2D (Collision2D coll){
		Destroy(gameObject);
	}
	
}

	
	

