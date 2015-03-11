﻿using UnityEngine;
using System.Collections;

public class EnemyLifeManager : MonoBehaviour {
	
	
	public int enemyhealth;// Health class
	protected virtual void Start()
	{
		enemyhealth = 100;// intial health value at start of game for both player and enemy
		
	}
	
	
	protected virtual void Update()
	{
		
	}
	public void setHealth(int number)
	{
		enemyhealth = number;
	}
	// obtains the value of health and returns it to the HealthBar class
	public float getHealth()
	{
		return enemyhealth;
	}
}

