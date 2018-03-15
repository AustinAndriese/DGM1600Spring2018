using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject {

//Functions with Return are when you take a function then instead of a void you use return for to"return"
//the function and add to it. It can be helpful in a game in many ways but the most common use would
//be when you are leveling up and the armour and weapons are leveling up with you as well as your enemies.


//Scope and Access modifiers are usable for shortening code. You can split up classes from MonoBehavior
//to scriptable objects, that way you can organize your project. You can split things up using 
//private, public, or protected. That way your classes can be accessed by specific code.

	protected float aNum;
	protected float bNum;

	public string Calculate (string a, string b)
	{
		aNum = float.Parse(a);
		bNum = float.Parse(b);

		return FinishCalculation();
	}
	
	public abstract string FinishCalculation();

}
