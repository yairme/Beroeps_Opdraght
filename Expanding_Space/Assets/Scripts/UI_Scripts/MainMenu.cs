using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private GameObject C;
    [SerializeField] private GameObject D;

    public void YouWin()
    {
        A.gameObject.SetActive(true);
        B.gameObject.SetActive(false);
        C.gameObject.SetActive(false);
        D.gameObject.SetActive(true);
    }
    public void Play()
    {
        A.gameObject.SetActive(true);
        B.gameObject.SetActive(false);
        C.gameObject.SetActive(false);
        D.gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void optionsMenu()
    {
        B.gameObject.SetActive(true);
        A.gameObject.SetActive(false);
    }

    public void Back()
    {
        B.gameObject.SetActive(false);
        A.gameObject.SetActive(true);
    }
}
