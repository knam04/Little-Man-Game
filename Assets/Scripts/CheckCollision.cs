using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{


    public bool isDestroyable = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemy")){
            if (isDestroyable){
                Debug.Log("Destroyed enemy!");
                Destroy(other.gameObject);
                Resources.Instance.addCoins(10);
                Debug.Log("Coins: " + Resources.Instance.getCoins);
            }
            else{
                GameManager.endGameDelegate();
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject.CompareTag("Door")){

            GameManager.endGameDelegate();
            Destroy(this.gameObject);
        }
    }

    


    // IEnumerator PowerupCountdownRoutine()
    // {
    //     yield return new WaitForSeconds(7);
    //     //hasPowerup = false; 
    // }

}
