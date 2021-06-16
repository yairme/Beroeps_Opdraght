using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenu : MonoBehaviour
{
    [SerializeField] private GameObject Settings;
    [SerializeField] private GameObject PauseMenu;
    public bool SettingsActive;

    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }

    public void settings()
    {
        Settings.SetActive(true);
        PauseMenu.SetActive(false);
        SettingsActive = true;
    }
    public void Back()
    {
        PauseMenu.SetActive(true);
        Settings.SetActive(false);
        SettingsActive = false;
    }

    /*
    public bool GetSettings()
    {
        return SettingsActive;
    }
    */



}
