using UnityEngine;
using System.Collections;

public class CountingCrystal : MonoBehaviour {

	public int crystalCount;
	public GUIStyle HUD;
	// Use this for initialization
	void Start () {
		crystalCount = 0;
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label (new Rect (10, 10, 200, 100), "Crystals: " + crystalCount,HUD);
	
	}
}
