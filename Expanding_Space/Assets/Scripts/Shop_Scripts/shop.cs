using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    private PlayerStats ST;
    private buildmanager BM;
    private Placement PS;

    private bool standard;
    private bool laser;
    private bool missle;
    [HideInInspector]public GameObject turret;
    public GameObject dashop;
    private GameObject grid;

    buildmanager Buildmanager;

    private void Start()
    {
        PS = GameObject.Find("Grid").GetComponent<Placement>();
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
    public void Placestandard()
    {
        
        if (ST.Money > 149)
        {
            Debug.Log("w");
            BM.Bal = true;
            Buildmanager.SetTurretToBuild(Buildmanager.standardturret);
            ST.Money -= 150;
        }
        else if (ST.Money < 149)
        {
            PS.rend.material.color = Color.red;
        }
    }
    public void Placelaser()
    {
        Debug.Log("s");
        if (ST.Money > 199)
        {
            BM.Bal = true;
            Buildmanager.SetTurretToBuild(Buildmanager.laserturret);
            ST.Money -= 200;
        }
        else if (ST.Money < 199)
        {
            PS.rend.material.color = Color.red;
        }
    }
    public void Placemissile()
    {
        Debug.Log("v");
        if (ST.Money > 299)
        {
            BM.Bal = false;
            Buildmanager.SetTurretToBuild(Buildmanager.Missileturret);
            ST.Money -= 300;
        }
        else if (ST.Money < 299)
        {
            PS.rend.material.color = Color.red;
        }
    }
}
