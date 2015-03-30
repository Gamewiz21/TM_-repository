using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform PlayerPrefab;// Prefab of the player
	public Transform spawnPoint;// Transform of the Spawnpoints
	private HealthBar L;

	public bool isAlive = true;


	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		L = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar> ();// gets script from Player "HealthBar"

		if (L.health <= 0)// if Health = Zero
		{	//Instantiate a player clone at the spawnpoints position/ rotation
			Instantiate(PlayerPrefab,spawnPoint.position, Quaternion.identity);

		
		}
	
	}
}
