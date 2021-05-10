using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    //Base class/AI for the enemies.
    protected float HP = 100f;
    protected float speed = 5f;
    protected float value = 1f;

    protected Transform target;
    protected int wavepointIndex = 0;

    private void Start()
    {
        target = WayPoints.wpoints[0];
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
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = WayPoints.wpoints[wavepointIndex];
    }
}
