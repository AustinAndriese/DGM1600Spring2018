using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {

public int Health;

public int AddHealth(int value)
{
	print("Hello There");
	return Health += value;
}
private void OnMouseDown()
{
	Health = AddHealth(10);
	Players.Add(NewPlayer("Bob"));
}

public List<string> Players;
public List<string> NewPlayers()
{
	return new List<string>();

}
public string NewPlayer(string Name)
{
	return Name;
}

}
