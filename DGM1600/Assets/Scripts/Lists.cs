using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lists : MonoBehaviour {
public Incredibles Incredibles;
	public Text AddMember;
private void OnMouseDown()
//Lists are similar to loops but can be manipulated in game by the player. You could use lists or loops depending on what the situation
//calls for. A good example of loops for me would be when you start a new game of zelda and they give you 3 game slots to make a new character
//Loops will limit the gamer to the options the programer set, when lists would give you more options and flexibility as the gamer.
{
	
	Incredibles.FamilyList.Add(AddMember.text);

		Incredibles.FamilyList.Add(AddMember.text);
		

		
	}
}
