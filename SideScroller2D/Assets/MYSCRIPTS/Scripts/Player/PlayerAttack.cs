using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	//private bool attacking = false;

	//private float attackTimer = 0;
	//private float attackCd = 0.3f;

	//public Collider2D Bullet;

	//private Animator anim;

	//private void Awake()
	//{
		//anim = gameObject.GetComponent<Animator>();
		//Bullet.enabled = false;
	//}

	//private void Update()
	//{
		//if (Input.GetKeyDown(KeyCode.Space) && !attacking)
		//{
			//attacking = true;
			//attackTimer = attackCd;

			//Bullet.enabled = true;

		//}

		//if (attacking)
		//{
			//if (attackTimer > 0)
			//{
				//attackTimer -= Time.deltaTime;
			//}
			//else
			//{
				//attacking = false;
				//Bullet.enabled = false;
			//}
		//}


		//anim.SetBool("IsAttacking", attacking);
	//}

}
