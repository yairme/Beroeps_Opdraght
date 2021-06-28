using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningSprites : MonoBehaviour
{
    private Enemy_Movement EN;

    [SerializeField] private GameObject Top;
    [SerializeField] private GameObject Right;
    [SerializeField] private GameObject Down;

    private void Start()
    {
        EN = GetComponent<Enemy_Movement>();
    }
    public void Update()
    {
        if (EN.eulerAngZ == 90f)
        {
            Down.gameObject.SetActive(false);
            Top.gameObject.SetActive(true);
            Right.gameObject.SetActive(false);
        }
        if (EN.eulerAngZ == 0f)
        {
            Down.gameObject.SetActive(false);
            Top.gameObject.SetActive(false);
            Right.gameObject.SetActive(true);
        }
        if (EN.eulerAngZ == -90f)
        {
            Down.gameObject.SetActive(true);
            Top.gameObject.SetActive(false);
            Right.gameObject.SetActive(false);
        }
    }
}
