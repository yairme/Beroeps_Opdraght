using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    [Header("Enemy stats")]
    public int count;
    public float rate;

    [Header("Enemy count/type")]
    public GameObject[] enemy;
}
