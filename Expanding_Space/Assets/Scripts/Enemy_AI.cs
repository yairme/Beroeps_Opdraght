using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class Enemy_AI : MonoBehaviour
{

    public float startSpeed = 10f;

    [HideInInspector]
    public float speed;

    public int startHealth = 100;
    private float health;

    public int value = 25;


    [Header("Unity stuff")]
    public Image healthBar;
=======

public class Enemy_AI : MonoBehaviour
{
    //Base class/AI for the enemies.
    protected float HP = 100f;
    protected float speed = 5f;
    protected float value = 1f;
>>>>>>> master

    protected Transform target;
    protected int wavepointIndex = 0;

    private void Start()
    {
<<<<<<< HEAD
        speed = startSpeed;
        target = WayPoints.wpoints[0];
    }

    public void TakeDamage (int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;
        
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += value;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }

=======
        target = WayPoints.wpoints[0];
    }

>>>>>>> master
    private void Update()
    {
        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

<<<<<<< HEAD
        if (Vector2.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }

        Vector3 dirL = WayPoints.wpoints[wavepointIndex].position - transform.position;
        float angle = Mathf.Atan2(dirL.y, dirL.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


=======
        if (Vector2.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

>>>>>>> master
    void GetNextWaypoint()
    {
        if (wavepointIndex >= WayPoints.wpoints.Length - 1)
        {
<<<<<<< HEAD
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WayPoints.wpoints[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}


=======
            Destroy(gameObject);
        }
        wavepointIndex++;
        target = WayPoints.wpoints[wavepointIndex];
    }
}
>>>>>>> master
