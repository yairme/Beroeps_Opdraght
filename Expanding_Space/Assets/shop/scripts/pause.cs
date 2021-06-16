using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool gameIsPaused;
    public bool PausedMenu;
    public GameObject pausetext;
    public GameObject pausemenu;
    private bool alreadypausedA = false;
    private bool alreadypausedB = false;
    public GameObject Settings;
    private QuitToMenu Quit;

    private void Start()
    {
        //Quit = Settings.GetComponent<QuitToMenu>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausedMenu = !PausedMenu;
            PausingMenu();
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
    
    void PausingMenu()
    {
        if (PausedMenu)
        {
            pausemenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausemenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
    /*
    public void SetSetttings(QuitToMenu set)
    {
        Settings = set;
    }
    */
}