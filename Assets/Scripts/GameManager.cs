using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;

    public delegate void EndGameDelegate();
    public static EndGameDelegate endGameDelegate;

    public GameObject player;
    public AudioSource audioSource;

    void Start(){
        endGameDelegate = EndGame;
        isGameActive = true;
        StartCoroutine("Music");

        Debug.Log("Starting coins: " + Resources.Instance.getCoins);
    }

    void Update(){
        if (player = null){
            endGameDelegate();
        }
    }

    IEnumerator Music(){
        audioSource.Play();
        yield return new WaitWhile((IsGameActive));
        audioSource.Stop();
    }

    private bool IsGameActive(){
        return isGameActive;
    }

    void EndGame(){
        isGameActive = false;

        Debug.Log("Game Over! Final coins: " + Resources.Instance.getCoins);
    }

}
