using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
public Player[] Players;
public int[] HighScores;

//Arrays are features where you add [] after int, string, etc. What this really does is open up slots in unity for you to add more
//than one item to print. This could be used to keep scores, players, etc in the database. These are primarily used for a set number
//and are meant for items that aren't changeable mid game. 

//Loops are primarily used to shorten your code. Used well with arrays, they can pretty much grab a set group of arrays and display them.
//Instead of manually listing each line of code, which could be hundreds of lines of code; you can use a loop to pretty much select the
//preferred lines: example: Select line 1-100. Etc
	void Start () {
		foreach(var player in Players)
		{
		print(player.PlayerName);
		print(player.Score);
		print(player.Health);
		}

		foreach(var score in HighScores)
	{
		if(score >= 1000)
		{
		print(score);
		}
	}
	}
}
