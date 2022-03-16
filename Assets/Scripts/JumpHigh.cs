using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerupData", menuName = "PowerupData/ jumpOrb")]
public class JumpHigh : PowerupData
{
    
    public override void Apply(GameObject collector){
        if (collector.name == "player" && hasPowerup)
        {
        collector.GetComponent<PlayerController>().jumpForce = 50;
        // collector.GetComponent<PlayerController>().jumpForce = 25;
        }
    }


}
