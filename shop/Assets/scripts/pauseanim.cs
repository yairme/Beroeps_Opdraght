using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pauseanim : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject pausetext;
    private pause paused;
    Animator pausing;


    private void Start()
    {
        paused = GameManager.GetComponent<pause>();
        pausing = pausetext.GetComponent<Animator>();

    }
    private void Update()
    {
        if (paused.gameIsPaused)
        {
            pausetext.gameObject.SetActive(true);
            //pausing.Play("pausing");
        }
    }
    
    private IEnumerator waitforsec()
    {
        pausing.Play("pausing");
        yield return new WaitForSeconds(0.167f);
        
    }
    
}
