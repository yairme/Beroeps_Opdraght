using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text moneyText;

    private PlayerStats MN;

    private void Start()
    {
        MN = GameObject.Find("GM").GetComponent<PlayerStats>();
    }
    void Update()
    {
        moneyText.text = "$" + MN.Money.ToString();
    }
}
