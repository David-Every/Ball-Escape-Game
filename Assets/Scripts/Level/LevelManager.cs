using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: "+name);
		Application.LoadLevel(name);
		
	}
	public void QuitRequest(){ // remove this apon putting game on mobile devices
		Debug.Log ("Quit Game requested");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
