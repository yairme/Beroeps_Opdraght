using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{

    public Button butt;
    //public GameObject prefab;

    private void Start()
    {
        //butt = prefab.GetComponent<Button>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Platform"))
        {



            butt.follow = false;
        }
    }
}
