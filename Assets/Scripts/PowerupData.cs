using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PowerupData : ScriptableObject
{
    public bool hasPowerup = false; 
    public string powerupName;

    // public string powerupDescription;
    // public GameObject powerupSprite; 
    // public double speed; 
    // public double  points; 
    
    public abstract void Apply(GameObject collector);

}

