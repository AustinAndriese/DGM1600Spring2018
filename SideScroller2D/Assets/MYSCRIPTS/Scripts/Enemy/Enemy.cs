using System.Collections;
using System.Collections.Generic;
using ProBuilder2.Common;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public float speed;
	public float distance;
	public bool MovingRight = true;
	public Transform GroundDetection;
	public GameObject Particle;
	public int EnemyHealth;


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
		}
	}

	//Damagesystem
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
	}

	public void Damage(int Dmg)
	{
		{
			EnemyHealth -= Dmg;
		}

		//EnemyHealth -= Dmg;
		//gameObject.GetComponent<Animation>().Play("AlphaBlink");
	}

}
	
