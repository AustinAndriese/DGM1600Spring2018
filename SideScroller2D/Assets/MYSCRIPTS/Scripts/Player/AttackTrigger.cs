using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{

	private Enemy enemy;

	void Start()
	{
		enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
		if (enemy != null)
		{
			print("Enemies Defeated");
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Enemy"))
		{
			enemy.Damage(20);
		}
	}

}