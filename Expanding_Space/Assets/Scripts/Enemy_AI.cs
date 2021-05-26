using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    //Base class/AI for the enemies.
    public float speed = 10f;

    protected Transform target;
    protected int wavepointIndex = 0;

    private void Start()
    {
        target = WayPoints.wpoints[0];
    }

    public void TakeDamage (int amount)
    {

        //Enemys types HP
        Enemy a = new Enemy();
        a.HP = 100;
        Enemy b = new Enemy();
        b.HP = 250;
        Enemy c = new Enemy();
        c.HP = 500;

        //Array
        int[] HPtypes = { a.HP, b.HP, c.HP };

        //Loop
        for (int i = 0; i < HPtypes.Length; i++)
        {
            HPtypes[i] -= amount;
        }  
        
        if (HPtypes[0] <= 0 || HPtypes[1] <= 0 || HPtypes[2] <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Enemy Types Money
        Enemy a = new Enemy();
        a.Value = 10;
        Enemy b = new Enemy();
        b.Value = 25;
        Enemy c = new Enemy();
        c.Value = 50;

        //MoneyType
        int[] MType = { a.Value, b.Value, c.Value };

        //Loop
        for (int i = 0; i < MType.Length; i++)
        {
            PlayerStats.Money += MType[i];
        }
        Destroy(gameObject);
    }

    private void Update()
    {
        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= WayPoints.wpoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WayPoints.wpoints[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}


/////Enemy types and different stats
public class Enemy
{
    public int HP;
    public int Value;
}


