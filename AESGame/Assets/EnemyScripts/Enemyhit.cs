using UnityEngine;
using System.Collections;

public class Enemyhit : MonoBehaviour {


		private HealthBar R;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		R = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar> ();
		if (other.gameObject.tag == "Enemy")
		{
			R.health -= 20;
		}
	}
}
