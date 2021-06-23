using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    private PlayerStats ST;

    void Start()
    {
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();
    }
    public void Update()
    {
        if (gameEnded)
            return;
        
        if (ST.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        //GameOver UI
    }
}
