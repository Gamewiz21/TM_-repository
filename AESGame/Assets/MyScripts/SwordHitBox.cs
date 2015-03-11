using UnityEngine;
using System.Collections;

public class SwordHitBox : MonoBehaviour {

	public bool InRange = false;

	 void Start()
	{

		
	}
	
	// Update is called once per frame
	void Update () {



		}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			InRange =true;
		}
	}
	void OnTriggerExit2D (Collider2D other)
	{

		InRange =false;

	}


}
