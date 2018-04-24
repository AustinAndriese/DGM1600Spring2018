using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Powerup PowerUpTransfer;

    private void OnTriggerEnter(Collider obj)
    {
        obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.MovePattern;
    }
}