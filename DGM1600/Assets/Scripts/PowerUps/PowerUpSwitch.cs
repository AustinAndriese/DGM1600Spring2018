using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

	public PowerUpBase MyPowerUp;
	void Start () {
		switch (MyPowerUp.PowerLevel)
		{
			case "":
				print("You just got more ammo");
				break;
		}
	
		
	}
}
