using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitShop : MonoBehaviour
{
    public Canvas shopUI;

    public void Exit()
    {
        shopUI.gameObject.SetActive(false);
    }
}
