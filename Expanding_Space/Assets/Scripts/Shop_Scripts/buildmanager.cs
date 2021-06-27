using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildmanager : MonoBehaviour
{
    public buildmanager instance;
    public GameObject sho;
    public bool i;

    public bool Bal = false;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("more than one buildmanager");
            return;
        }
        instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            i = !i;
            if (i)
            {
                sho.SetActive(true);
            }
            else
            {
                sho.SetActive(false);
            }
        }
    }

    public GameObject standardturret;
    public GameObject laserturret;
    public GameObject Missileturret;

    private void Start()
    {
        turrettobuild = standardturret;
        
    }

    private GameObject turrettobuild;
    public GameObject getturrettobuild()
    {
        Bal = false;
        return turrettobuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turrettobuild = turret;
    }
}
