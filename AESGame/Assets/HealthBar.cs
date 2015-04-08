using UnityEngine;
using System.Collections;

public class HealthBar : HealthManager {

    public GUIStyle HUD;
	// Use this for initialization
    protected override void Start()
    {
        base.Start();

     }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 300, 150), "Health: " + health,HUD);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spike")
        {
            health -= 10;
        }
    }
}
