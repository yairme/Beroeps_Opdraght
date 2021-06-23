﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    public Color hovercolor;
    private Color startcolor;
    private SpriteRenderer rend;
    private GameObject turret;
    public bool activeshop;
    public GameObject dashop;
    private shop build;

    buildmanager Buildmanager;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startcolor = rend.material.color;
        build = dashop.GetComponent<shop>();
        Buildmanager = buildmanager.instance;
    }


    private void OnMouseDown()
    {
        if(Buildmanager.getturrettobuild() == null)
        {
            return;
        }
        if(turret != null)
        {
            Debug.Log("already build here TODO: display on screen");
            return;
        }
        GameObject TurretToBuild = Buildmanager.getturrettobuild();
        turret = (GameObject)Instantiate(TurretToBuild, transform.position, transform.rotation);

    }

    private void OnMouseEnter()
    {
        rend.material.color = hovercolor;
    }
    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }
}
