using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{

	public float Timer;
	
	public void Update ()
	{
		Timer -= Time.deltaTime;
		if (Timer <= 0)
			Destroy(gameObject);
	}
}
