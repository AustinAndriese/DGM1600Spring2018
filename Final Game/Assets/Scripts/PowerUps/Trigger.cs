using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public Powerup Powerup;
	private MovePattern prevMovePattern;

	private void OnTriggerEnter(Collider obj)
	{
		prevMovePattern = obj.GetComponent<MoveCharacter>().MovePattern;

		obj.GetComponent<MoveCharacter>().MovePattern = Powerup.MovePattern;


		
		gameObject.SetActive(false);

	}
	void RestoreMovePattern(MovePattern oldMovePattern)
	{

	}
}
