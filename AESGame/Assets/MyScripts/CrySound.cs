using UnityEngine;
using System.Collections;

public class CrySound : CrystalGet {

    public AudioClip MyClip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Got == true)
        {
            audio.PlayOneShot(MyClip);
        }
	}
}
