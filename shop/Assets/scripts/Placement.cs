using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    public Color hovercolor;
    private Color startcolor;
    private SpriteRenderer rend;
    private GameObject turret;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startcolor = rend.material.color;
    }


    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("already build here TODO: display on screen");
            return;
        }
        GameObject TurretToBuild = buildmanager.instance.standardturret;
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
