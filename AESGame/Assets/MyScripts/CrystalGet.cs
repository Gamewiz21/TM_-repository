using UnityEngine;
using System.Collections;

public class CrystalGet : MonoBehaviour {

	// private value crycounter
	private CountingCrystal cryCounter;

	public static bool Finished = false;

	// Use this for initialization
	void Awake ()
	{
		// cryCounter gets the value of of the Counting Crystal gameobject
		cryCounter = GameObject.Find("CounterCrystal").GetComponent<CountingCrystal>();

	}
	
	void OnTriggerEnter2D(Collider2D other)
	{	// once the player comes in contact with the colliider
		if (other.gameObject.tag == "Player")
		{	// increment the value of CrystalCount within the CounterCrystal
			cryCounter.crystalCount++;
			//afterward the object will be set as inActive
			this.gameObject.SetActive(false);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
