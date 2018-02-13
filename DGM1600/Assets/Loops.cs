using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
public string[] Players;
public int[] Scores;

	void Start () {
		foreach(var player in Players);
		print(Players);
	
		foreach(var score in Scores);
		print(Scores);
	}
}
