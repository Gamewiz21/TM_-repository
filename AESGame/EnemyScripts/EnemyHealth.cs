using UnityEngine;
using System.Collections;

public class EnemyHealth : EnemyLifeManager {

	public SwordHitBox hitBox;
    // Use this for initialization

	void Awake() 
	{	// hitbox equals the components from the SwordHitBox script
		hitBox = GameObject.Find("Hitbox0").GetComponent<SwordHitBox>(); 

	}
    protected override void Start()
    {
        base.Start();

	

    }

    // Update is called once per frame
    void Update()
    {
		// if the player presses 0 and InRange is set as true
		if (Input.GetKeyDown (KeyCode.O) && hitBox.InRange == true) 
		{ // enemy loses 30 health
			enemyhealth -= 30;
			//Debug.Log("hit");
		}
		// if enemyhealth equal 0
        if (enemyhealth <= 0)
        { 	// destroy gameObject
            Destroy (this.gameObject);
        }

    }

   

    void OnTriggerEnter2D(Collider2D other)
    {	//if the weapon itself touches the collider
        if (other.gameObject.tag == "Weapon")
        {	//enemy loses 30 health
            enemyhealth -= 30;
        }

       
    }
}
