using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningSprites : MonoBehaviour
{
    private Enemy_Movement EN;

    public Sprite spriteLeft, spriteRight, spriteUp, spriteDown;

    private void Start()
    {
        EN = this.gameObject.GetComponent<Enemy_Movement>();
    }
    public void Update()
    {
        if (EN.eulerAngZ <= 90f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
        }
        if (EN.eulerAngZ <= 0f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
        }
        if (EN.eulerAngZ <= -90f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
        }
        if (EN.eulerAngZ <= 180f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
        }
    }
}
