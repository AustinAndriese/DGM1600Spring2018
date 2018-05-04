using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ProBuilder2.Common;
using UnityEngine;
using UnityEngine.WSA;

public class Enemy : MonoBehaviour
{

	public float speed;
	public float distance;
	public bool MovingRight = true;
	public Transform GroundDetection;
	public GameObject Particle;
	public GameObject EnemyAi;
	public int EnemyHealth;
	public Enemy enemy;
	private GameMaster GM;


	void Update()
	{
		//PatrolScript
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
			//Instantiate(Particle, Transform.position, Transform.rotation);
			Destroy(gameObject);
			GM.Points += 10;
		}
	}

	//Damagesystem
	private Character character;

	void Start()
	{
		character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
		
		GM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			character.Damage(1);
		}
		//StartCoroutine(character.Knockback(0.02f, 350, character.transform.position));
	}

	public void Damage(int Dmg)
	{
		{
			EnemyHealth -= Dmg;
		}

		//EnemyHealth -= Dmg;
		//gameObject.GetComponent<Animation>().Play("AlphaBlink");
	}

	public Enemies enemies;
	
	public enum Enemies
	{
		EnemyAi1,
		EnemyAi2,
		EnemyAi3
		
	}
void EnemiesDestroyed()
{
	switch (enemies)
	{
		case Enemies.EnemyAi1:
			print("Enemy1");
			break;
		case Enemies.EnemyAi2:
			print("Enemy2");
			break;
		case Enemies.EnemyAi3:
			print("Enemy3");
			break;
		default:
			print("Enemies Defeated");
			break;
	}

}
		

}
	
