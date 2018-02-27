using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public string[] Keys;
//Using For Loops is similar and slightly more complex than using "for each" loops. It is a little more
//specific and can add slight variables where fore each loops may not be viable. This is usable
//for checking and displaying numerous lines of code without you personally having to type in each
//line individually. These loops may not be as popular as the "for each" type but it is good to 
//know the code and understand what its doing for when it becomes necessary.
public class ForLoops : MonoBehaviour {
	void Start () {
		for (int i = 0; i < Keys.Length; i++)
		
		if (Keys[i] == "Add Ammo")
		{
			print(Keys[i]);
		}
		
	}

}
