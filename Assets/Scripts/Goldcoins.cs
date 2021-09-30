using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goldcoins : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D coll){
		Destroy(this.gameObject);
	
	
		}

}
