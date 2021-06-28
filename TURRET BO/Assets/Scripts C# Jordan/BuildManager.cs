using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance; //public cuz you want to acces it without the class and static cuz you want it to be shared with all build manegers
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("More Then One BuildManager in Scene!");
            return;
        }
        instance = this;
    }

    public GameObject StandardTurretPrefab;

    void Start ()
    {
        turretToBuild = StandardTurretPrefab;
    }
    private GameObject turretToBuild;
    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }
}
