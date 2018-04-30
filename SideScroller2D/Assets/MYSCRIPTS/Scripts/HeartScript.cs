using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScript : MonoBehaviour
{

    public Sprite[] HeartSprites;

    public Image HeartUI;

    private Character player;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    void Update ()
    {
        HeartUI.sprite = HeartSprites[player.Health];
    }
}
