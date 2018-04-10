using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatInput : InputBase 
{

	public string InputName = "Horizontal";

	public override float SetFloat()
	{
		return Input.GetAxis(InputName);
	}

}
