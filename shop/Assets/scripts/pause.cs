using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool gameIsPaused;
    public GameObject pausetext;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameIsPaused = !gameIsPaused;
            pausetext.SetActive(true);
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            pausetext.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausetext.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
