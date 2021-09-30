using UnityEngine;
using System.Collections;

public class Electricity : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.tag =="Player"){
			Destroy(coll.gameObject);
			print ("LoadLevel 'Lose'");
		}
	}
}
