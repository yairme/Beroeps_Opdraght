using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text moneyText;
    public Text liveText;

    private PlayerStats MN;

    private void Start()
    {
        MN = GameObject.Find("GM").GetComponent<PlayerStats>();
    }
    void Update()
    {
        moneyText.text = "$" + MN.Money.ToString();
        liveText.text = MN.Lives.ToString();
    }
}
