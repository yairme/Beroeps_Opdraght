using UnityEngine;
using System.Collections;


public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 1;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }
}
