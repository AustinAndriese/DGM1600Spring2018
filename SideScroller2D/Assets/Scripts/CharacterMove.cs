using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

	public int Speed =10;
	public SpriteRenderer sr;
	public Animator anim;
	public float JumpForce;
	public Rigidbody2D rig;
	public bool IsGrounded;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Movement();
		if(IsGrounded) anim.SetBool("IsGrounded", true);
		else anim.SetBool("IsGrounded", false);
		//if (rig.velocity.y < 0)
		{
			//rig.velocity.y += Vector2.up * Physics2D.gravity.y * 2 * Time.deltaTime;
		}
	}

	void Movement()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (IsGrounded)
			{
				rig.AddForce(Vector2.up * JumpForce);
				IsGrounded = false;
			}
		}
		if (Input.GetKey(KeyCode.D))
		{
			anim.SetBool("IsWalking", true);
			transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
			sr.flipX = false;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			anim.SetBool("IsWalking", true);
			transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
			sr.flipX = true;
		}
		else anim.SetBool("IsWalking", false);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground")
		{
			IsGrounded = true;
			anim.SetBool("IsGrounded", true);
		}
	}
}
