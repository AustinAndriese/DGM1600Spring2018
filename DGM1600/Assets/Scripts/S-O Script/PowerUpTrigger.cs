using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp MyPowerUp;
	public Player MyPlayer;

	void OnTriggerEnter()
	{
		AddPower (MyPowerUp);
	}
	void AddPower (PowerUp powerup)	
	{
			print(powerup.PowerLevel);
	}
	
}
