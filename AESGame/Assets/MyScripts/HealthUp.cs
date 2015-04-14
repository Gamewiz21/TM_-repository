using UnityEngine;
using System.Collections;

public class HealthUp : MonoBehaviour {

//<<<<<<< HEAD
    private HealthBar Plus;
    
//=======
	public AudioSource HealthClip;// AudioSource
//>>>>>>> 098f8dd... Sound integrated
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
//<<<<<<< HEAD
            this.gameObject.SetActive(false);
            Plus.health +=25;
        }
        /*
        if (Plus.health >= 100)
        {
          
        }
         * */
//=======
			HealthClip.Play ();//Plays Clip
            this.gameObject.SetActive(false);// set object to inActive
            Plus.health +=25;// increase health value by 25
        }
        
//>>>>>>> 098f8dd... Sound integrated
}
    

