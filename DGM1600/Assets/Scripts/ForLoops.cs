using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public string[] Keys;

public class ForLoops : MonoBehaviour {
	void Start () {
		for (int i = 0; i < Keys.Length; i++)
		
		if (Keys[i] == "Add Ammo")
		{
			print(Keys[i]);
		}
		
	}

}
