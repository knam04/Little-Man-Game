using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
 
    public PowerupData powerupData;


    public void OnTriggerEnter2D(Collider2D toucher){
        if (toucher.gameObject.name == "player"){
            powerupData.hasPowerup = true; 

            Destroy(gameObject);
            powerupData.Apply(toucher.gameObject);
            Debug.Log("You can now " + powerupData.powerupName.ToLower() + "!");


        }  
    }

    /*IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(3);
        powerupData.hasPowerup = false; 
    }*/
}