using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;

    private Renderer rend;
    private Color StartColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        StartColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("can't build there! - TODO: Display on screen.");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        //build a turret
    }
    // Start is called before the first frame update
    void OnMouseEnter ()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit ()
    {
        rend.material.color = StartColor;
    }
}