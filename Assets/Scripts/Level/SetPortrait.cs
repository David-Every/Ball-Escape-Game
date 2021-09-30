using UnityEngine;
using System.Collections;

public class SetPortrait : MonoBehaviour {


	void Awake (){//forces the game to be played in portrait shouldnt auto rotate during gameplay!
		Screen.orientation = ScreenOrientation.Portrait;
	}
}
