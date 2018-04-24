using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
	public float PowerLevel = 0.2f;
	//public Image HealthBar;
	public PowerUp PowerUpTransfer;

	void OnTriggerEnter(Collider obj)
	{
		
		
		//if (HealthBar.fillamount > 1)
		{
			//obj.GetComponent<CharacterMove>().move.pattern = PowerTransfer.movepattern;
		}
	}


}
