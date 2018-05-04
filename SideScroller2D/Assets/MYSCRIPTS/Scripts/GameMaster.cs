using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

	public int Points;
	public Text PointsText;

	void Update()
	{
		PointsText.text = ("Points: " + Points);
	}
	
	
	
}
