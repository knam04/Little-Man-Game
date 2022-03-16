using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    private static Resources _instance;

    public static Resources Instance{
        get{
            return _instance;
        }
    }

    private int coins;
    public int getCoins{
        get{
            return coins;
        }
    }
    public void addCoins(int num){
        Debug.Log("You just got " + num + " coins!");
        coins += num; 

    }
    
    // Start is called before the first frame update
    private void Awake(){
        if(_instance != null && _instance != this){
            Destroy(this.gameObject);
        }
        else{
            _instance = this;
        }
    }
}
