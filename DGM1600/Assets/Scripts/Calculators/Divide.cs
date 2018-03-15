using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Divide : Calculation {

	public override string FinishCalculation()
	{
		return (aNum / bNum).ToString(); 
	}
		
}
