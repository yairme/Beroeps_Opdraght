using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    private bool standard;
    private bool laser;
    private bool missle;
    [HideInInspector]public GameObject turret;
    public GameObject dashop;
    private GameObject grid;

    buildmanager Buildmanager;

    private void Start()
    {
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
        Buildmanager.SetTurretToBuild(Buildmanager.standardturret);
    }
    public void placelaser()
    {
        Buildmanager.SetTurretToBuild(Buildmanager.laserturret);
    }
    public void placemissle()
    {
        Buildmanager.SetTurretToBuild(Buildmanager.Missleturret);
    }
}
