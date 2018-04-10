using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public float speed = 6.0f;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection;
	private Vector3 rotateDirection;

	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
void Update()
	if (ControllerColliderHit.isGrounded)
	{
		
	}
	
}
