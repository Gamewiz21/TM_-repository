using UnityEngine;
using System.Collections;

public class ButtonPower : MonoBehaviour {

	public GameObject Floor1;
	public GameObject Floor2;
	public GameObject Floor3;
	public bool CanBePressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKeyDown(KeyCode.G) && CanBePressed == true)
		   {

			Floor1.SetActive(true);
			Floor2.SetActive(true);
			Floor3.SetActive(true);
		}
		
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			CanBePressed = true;
		}

	}
	void OnTriggerExit2D (Collider2D other)
	{
		CanBePressed = false;
	}
}
