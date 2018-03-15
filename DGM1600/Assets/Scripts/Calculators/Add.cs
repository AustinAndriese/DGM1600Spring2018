using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Add : Calculation {

	public override string FinishCalculation()
	{
		return (aNum + bNum).ToString();
	}
	
}
