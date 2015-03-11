using UnityEngine;
using System.Collections;

public class SlashAttack : MonoBehaviour {

	Animator Anim;

	// Use this for initialization
	void Awake () {

		Anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.O))
            Anim.Play("Swords");
        
			
	
	}
}
