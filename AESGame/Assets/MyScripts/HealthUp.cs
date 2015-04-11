using UnityEngine;
using System.Collections;

public class HealthUp : MonoBehaviour {

    private HealthBar Plus;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Plus = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar>();
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            Plus.health +=25;
        }
        /*
        if (Plus.health >= 100)
        {
          
        }
         * */
    }
    
}
