using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lists : MonoBehaviour {
public Incredibles Incredibles;
	public Text AddMember;
private void OnMouseDown()
{
	
	Incredibles.FamilyList.Add(AddMember.text);

		Incredibles.FamilyList.Add(AddMember.text);
		

		
	}
}
