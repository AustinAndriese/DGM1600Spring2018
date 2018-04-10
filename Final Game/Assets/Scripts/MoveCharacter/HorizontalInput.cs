using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(filename = "NewInput")]
public class HorizontalInput : InputBase {

	public override float FloatInput ()
	{
		return Input.GetAxis("Horizontal");

	}
}
