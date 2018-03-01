using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour 
{
//Functions with Parameters are pretty much extra code that can be more specific and lengthy but
//over all, can save you time. The Idea is that you Name something, give it a property (number), and 
//then below assign the object to do work when acted apon. This can be helpful because it is inter
//changable and can help you assign objects throughout the game without having to write code after
//code on each level.
public int b;
public int Health = 20;
public int Damage = 0;

Collider Other;

void OnTriggerEnter(Collider other)
{
	print("Hit Somehting");
	print(other);

	AddNumbers(14,2);
	PlayerData("Bob");

}
void AddNumbers (int a, int b)
{
	print(a =+ b);
}	
	void PlayerData(string name)
	{
		print("This player is " + name);
	}
void OntTriggerEnter()
{
	AddHealth(25);
}
	void AddHealth(int NewHealth)
	{
		Health += NewHealth;
	}


void OnTriggerEnter()
{
	AddDamage(100);
}
	void AddDamage(int NewDamage)
	{
		Damage += NewDamage;
	}
}
