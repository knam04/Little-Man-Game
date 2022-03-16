using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerupData", menuName = "PowerupData/ destroyFruit")]
public class DestroyEnemy : PowerupData
{

    public override void Apply(GameObject collector){
        Debug.Log("inDestroyEnemy");
        collector.GetComponent<CheckCollision>().isDestroyable = true; 
    }
}
