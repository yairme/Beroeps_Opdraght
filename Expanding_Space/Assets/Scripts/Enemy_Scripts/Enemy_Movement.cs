using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    private WayPoints WP;
    private WaveSpawner WS;
    private PlayerStats ST;

    protected Transform target;
    protected int wavepointIndex = 0;

    private void Start()
    {
        WP = GameObject.Find("waypoint").GetComponent<WayPoints>();
        WS = GameObject.Find("GameMaster").GetComponent<WaveSpawner>();
        ST = GameObject.Find("GameMaster").GetComponent<PlayerStats>();

        target = WP.wpoints[0];
    }
    private void Update()
    {
        Enemy_AI EN = GetComponent<Enemy_AI>();

        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * EN.speed * Time.deltaTime, Space.World);


        if (Vector2.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        Vector3 dirL = WP.wpoints[wavepointIndex].position - transform.position;
        float angle = Mathf.Atan2(dirL.y, dirL.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        EN.speed = EN.startSpeed;
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= WP.wpoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WP.wpoints[wavepointIndex];
    }

    void EndPath()
    {
        ST.Lives--;
        WS.EnemiesAlive--;
        Destroy(gameObject);
    }
}
