using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpReturn : MonoBehaviour {

//increases its power levels every time you hit it.

public Player CurrentPlayer;

public int PowerLevel = 10;

public int PowerLevelIncrease = 2;

public int IncreasePowerLevel ()
{
	return PowerLevel *= PowerLevelIncrease;

}

private void OnMouseDown()
{
	CurrentPlayer.Health = IncreasePowerLevel();
}


}
