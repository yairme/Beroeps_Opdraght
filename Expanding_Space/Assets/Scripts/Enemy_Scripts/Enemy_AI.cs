using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_AI : MonoBehaviour
{
    private WaveSpawner WS;
    private PlayerStats ST;


    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;

    public float startHealth = 100f;
    private float health;

    public int value;

    [Header("Unity stuff")]
    public Image healthBar;


    private void Start()
    {
        WS = GameObject.Find("GameMaster").GetComponent<WaveSpawner>();
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();

        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;
        
        if (health <= 0)
        {
            Die();
        }
    }

    public void Slow (float pct)
    {
        speed = speed * (1f - pct);
    }

    void Die()
    {
        ST.Money += value;
        WS.EnemiesAlive--;
        Destroy(gameObject);
    }
}

