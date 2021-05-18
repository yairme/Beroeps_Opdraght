using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureaids : MonoBehaviour
{
    public GameObject obama;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Instantiate(obama, obama.transform.position, obama.transform.rotation);
        StartCoroutine(waitforsec());

    }


    private IEnumerator waitforsec()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(obama, obama.transform.position, obama.transform.rotation);
    }
}
