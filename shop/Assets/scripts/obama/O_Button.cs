using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_Button : MonoBehaviour
{
    [HideInInspector] public Inventory inv;
    public GameObject shopmanager;
    public GameObject turret;
    public GameObject spawn;
    public int random;

    public void Start()
    {
        inv = shopmanager.GetComponent<Inventory>();

    }


    public void buy()
    {
        Debug.Log("bought");
        if (inv.Points > 0)
        {
            random = Random.Range(0, 100);
            Debug.Log(random);
            Debug.Log(inv.Points);
            for (int i = 2; i >= 0; i--)
            {
                Instantiate(turret, spawn.transform.position, spawn.transform.rotation);
            }
            inv.Points -= 5;
            /*
            random = Random.Range(0, 10);
            inv.Points -= 5;
            Instantiate(turret, spawn.transform.position, spawn.transform.rotation);
            Debug.Log(inv.Points);
            */
        }
        else
        {
            Debug.Log("no points");
        }
    }





}
