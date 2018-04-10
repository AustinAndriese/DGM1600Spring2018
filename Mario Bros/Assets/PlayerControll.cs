using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {

public int PlayerSpeed = 10;
public bool FacingRight = true;
public int PlayerJumpPower = 1250;
public float moveX;


	
	// Update is called once per frame
	void Update () 
	{
		PlayerMove ();
	}
	void PlayerMove ()
	{
		moveX = Input.GetAxis("Horizontal");
		
		if (moveX < 0.0f && FacingRight == false)
		{
			FlipPlayer ();
		}
		else if (moveX > 0.0f && FacingRight == true)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
		}	
	}
	void Jump();
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * PlayerJumpPower);
	}
	void FlipPlayer() 
	{
		FacingRight = !FacingRight;
		Vector2 localscale = GameObject.transform.localScale;
		localscale.x *= -1;
		Transform.localscale = localscale;
	}

	}
}
