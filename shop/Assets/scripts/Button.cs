using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [HideInInspector] public Inventory inv;
    public GameObject shopmanager;
    public GameObject turret;
    public GameObject spawn;
    [HideInInspector] public bool hasbought;
    Vector3 worldPosition;
    [HideInInspector]public bool follow;
    private GameObject GO;
    public void Start()
    {
        inv = shopmanager.GetComponent<Inventory>();
        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    public void buy()
    {
        Debug.Log("bought");
        if (inv.Points > 0)
        {

            inv.Points -= 5;
            hasbought = true;
            if (hasbought == true)
            {
                follow = true;
                GO = Instantiate(turret, spawn.transform.position, spawn.transform.rotation);
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = Camera.main.nearClipPlane;
                GO.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
            }


        }
       
        else
        {
            Debug.Log("no points");
        }

    }

    private void Update()
    {
        if (follow == true)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            GO.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
        
    }

    private void OnMouseEnter()
    {
        if (gameObject.CompareTag("Platform"))
        {
            follow = false;
        }
    }



}
