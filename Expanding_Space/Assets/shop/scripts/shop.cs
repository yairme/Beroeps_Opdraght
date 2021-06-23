using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    private PlayerStats ST;
    private bool standard;
    private bool laser;
    private bool missle;
    [HideInInspector]public GameObject turret;
    public GameObject dashop;
    private GameObject grid;

    buildmanager Buildmanager;

    private void Start()
    {
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();
        Buildmanager = buildmanager.instance;
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
            Buildmanager.SetTurretToBuild(Buildmanager.standardturret);
            ST.Money -= 150;
        }
    }
    public void placelaser()
    {
        if (ST.Money >= 199)
        {
            Buildmanager.SetTurretToBuild(Buildmanager.laserturret);
            ST.Money -= 200;
        }
    }
    public void placemissle()
    {
        if (ST.Money >= 299)
        {
            Buildmanager.SetTurretToBuild(Buildmanager.Missleturret);
            ST.Money -= 300;
        }
    }
}
