using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Calculation : ScriptableObject {

	public int Calculate(string a, string b)
	{
		int anum = int.Parse(a);
		int bnum = int.Parse(b);
		return anum + bnum;
	}	
	
}
