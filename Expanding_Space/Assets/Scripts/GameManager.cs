using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

<<<<<<< HEAD
<<<<<<< HEAD
    private PlayerStats ST;

    void Start()
    {
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();
    }
=======
>>>>>>> parent of 1a2cfd0 (Live bug fixed.)
    public void Update()
    {
        if (gameEnded)
            return;
        
<<<<<<< HEAD
        if (ST.Lives <= 0)
=======
    void Update()
    {
        if (gameEnded)
            return;

        if (PlayerStats.Lives <= 0)
>>>>>>> parent of 3cf3400 (Wave spawner 2.0)
=======
        if (PlayerStats.Lives <= 0)
>>>>>>> parent of 1a2cfd0 (Live bug fixed.)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over");
    }
}
