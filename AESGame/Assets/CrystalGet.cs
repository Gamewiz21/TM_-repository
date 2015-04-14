using UnityEngine;
using System.Collections;

public class CrystalGet : MonoBehaviour {


	private CountingCrystal cryCounter;

	public static bool Finished = false;

	// Use this for initialization
	void Awake ()
	{
		
		cryCounter = GameObject.Find("CounterCrystal").GetComponent<CountingCrystal>();

	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			cryCounter.crystalCount++;

			this.gameObject.SetActive(false);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
