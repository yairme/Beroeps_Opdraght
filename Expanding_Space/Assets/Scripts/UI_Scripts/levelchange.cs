using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchange : MonoBehaviour
{
    public void moon()
    {
        SceneManager.LoadScene("moon");
    }
    public void mars()
    {
        SceneManager.LoadScene("mars");
    }
    public void demo()
    {
        SceneManager.LoadScene("Demo");
    }
}
