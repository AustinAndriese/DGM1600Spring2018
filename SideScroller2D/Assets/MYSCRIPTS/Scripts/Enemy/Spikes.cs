using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

	private Character character;

	void Start()
	{
		character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			character.Damage(1);
		}
		StartCoroutine(character.Knockback(0.02f, 350, character.transform.position));
	}

}
