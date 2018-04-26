using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform target;
	public float smoothspeed = 0.125f;
	public Vector3 Offset;

	void LateUpdate()
	{
		transform.position = target.position + Offset;
	}
}
