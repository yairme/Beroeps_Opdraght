using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [HideInInspector]
    public Transform[] wpoints;

    private void Awake()
    {
        Debug.Log("Yes Awake");
        wpoints = new Transform[transform.childCount];
        for (int i = 0; i < wpoints.Length; i++)
        {
            Debug.Log("Yes loop");
            wpoints[i] = transform.GetChild(i);
        }
    }

}
