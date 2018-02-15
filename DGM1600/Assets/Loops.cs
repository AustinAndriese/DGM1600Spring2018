using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
public Player[] Players;
public int[] HighScores;

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
