using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildmanager : MonoBehaviour
{
    public static buildmanager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("more than one buildmanager");
            return;
        }
        instance = this;
    }

    public GameObject standardturret;

    private void Start()
    {
        turrettobuild = standardturret;
    }

    private GameObject turrettobuild;
    public GameObject getturrettobuild()
    {
        return turrettobuild;
    }
}
