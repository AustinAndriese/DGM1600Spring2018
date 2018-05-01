﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public float speed;
	public float distance;
	public bool MovingRight = true;
	public Transform GroundDetection;
	public int EnemyHealth;
	

	void Update()
	{ //PatrolScript
		transform.Translate(Vector2.right * speed * Time.deltaTime);
		
		RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, distance);
		
		if (groundInfo.collider == false)
		{
			if (MovingRight == true)
			{
				transform.eulerAngles = new Vector3(0, 180, 0);
				MovingRight = false;
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				MovingRight = true;
			}
		}

		if (EnemyHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
	//Damagesystem
	public void Damage(int damage)
	{
		EnemyHealth -= damage;
		gameObject.GetComponent<Animation>().Play("Player_RedFlash");
	}
}
