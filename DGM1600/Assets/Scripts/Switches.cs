using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public string UserName;
	public string Name;
	//Switch is similar to an if statement, but instead of a true or false mentality, it allows you to have more options (more than just 2).
	//You use case for each selection, and close off the selection by using break. Break helps the computer save time and data by stopping
	//search once the answer is found instead of searching for all possible answers.
	void Start () {
		switch (UserName)
		{
			case "Password":
				print("Password is correct");
				break;
			case "LevelUp":
				print("You win! Next Level");
				break;
			case "BlackPanther":
				print("Made over 200 million this weekend!");
				break;

			default:
				print("Why don't you just tell me which movie you want to see?");
			break;
		}
		switch (Name)
		{
			case "Link":
			print("Legend of Zelda");
			break;
			case "Ash":
			print ("Pokemon!");
			break;
			case "Peter Parker":
			print ("Spiderman");
			break;
			case "TonyStark":
			print ("I am Iron Man!");
			break;
			case "Pikachu":
			print("I choose you!");
			break;

			default:
				print ("Wrong!");
			break;
		}
	}
}
