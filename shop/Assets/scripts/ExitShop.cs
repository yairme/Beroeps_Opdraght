using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitShop : MonoBehaviour
{
    public Canvas shopUI;
    Animator exit;
    public GameObject shop;


    private void Start()
    {
        exit = shop.GetComponent<Animator>();
    }
    public void Exit()
    {
        StartCoroutine(waitforsec());
    }

    private IEnumerator waitforsec()
    {
        exit.Play("shop_exit");
        //()=> exit.isPlaying == false
        yield return new WaitForSeconds(0.167f);
        shopUI.gameObject.SetActive(false);
    }
}
