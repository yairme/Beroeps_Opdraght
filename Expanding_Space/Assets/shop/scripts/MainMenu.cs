using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject Main;
    [SerializeField] private GameObject options;

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void optionsMenu()
    {
        options.gameObject.SetActive(true);
        Main.gameObject.SetActive(false);
    }

    public void Back()
    {
        options.gameObject.SetActive(false);
        Main.gameObject.SetActive(true);
    }
}
