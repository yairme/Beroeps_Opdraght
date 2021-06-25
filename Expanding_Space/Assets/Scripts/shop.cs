using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    private PlayerStats ST;
    private buildmanager BM;

    private bool standard;
    private bool laser;
    private bool missle;
    [HideInInspector]public GameObject turret;
    public GameObject dashop;
    private GameObject grid;

    buildmanager Buildmanager;

    private void Start()
    {
        BM = GameObject.Find("GameMaster").GetComponent<buildmanager>();
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();
        Buildmanager = BM.instance;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            dashop.SetActive(true);
        }
    }
    public void placestandard()
    {
        if (ST.Money >= 149)
        {
            BM.Bal = true;
            Buildmanager.SetTurretToBuild(Buildmanager.standardturret);
            ST.Money -= 150;
        }
        else if (ST.Money <= 149)
        {
            Debug.Log("Not enough money");
        }
    }
    public void placelaser()
    {
        if (ST.Money >= 199)
        {
            BM.Bal = true;
            Buildmanager.SetTurretToBuild(Buildmanager.laserturret);
            ST.Money -= 200;
        }
        else if (ST.Money <= 199)
        {
            Debug.Log("Not enough money");
        }
    }
    public void placemissle()
    {
        if (ST.Money >= 299)
        {
            BM.Bal = false;
            Buildmanager.SetTurretToBuild(Buildmanager.Missleturret);
            ST.Money -= 300;
        }
        else if (ST.Money <= 299)
        {
            Debug.Log("Not enough money");
        }
    }
}
