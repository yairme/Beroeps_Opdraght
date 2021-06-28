using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;

    private PlayerStats ST;
    private levelchange LC;

    void Start()
    {
        ST = GameObject.Find("GM").GetComponent<PlayerStats>();
        LC = GameObject.Find("GM").GetComponent<levelchange>();
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
        LC.Lose();
    }
}
