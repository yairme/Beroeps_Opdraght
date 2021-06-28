using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    private WayPoints WP;
    private WaveSpawner WS;
    private PlayerStats ST;
    [SerializeField]
    private Enemy_AI EN;

    protected Transform target;
    protected int wavepointIndex = 0;

    public float eulerAngZ;

    private void Start()
    {
        //WP = GameObject.Find("Waypoint").GetComponent<WayPoints>();
        WP = GameObject.FindWithTag("WayPoints").GetComponent<WayPoints>();
        WS = GameObject.Find("GM").GetComponent<WaveSpawner>();
        ST = GameObject.Find("GM").GetComponent<PlayerStats>();

        target = WP.wpoints[0];
        eulerAngZ = transform.localEulerAngles.z;
        EN = this.gameObject.GetComponent<Enemy_AI>();
    }
    private void Update()
    {
        if (target != null)
        {
            Vector2 dir = target.position - transform.position;
            transform.Translate(dir.normalized * EN.speed * Time.deltaTime, Space.World);
        }
        else
        {
            //WP = GameObject.Find("Waypoint").GetComponent<WayPoints>();
            WP = GameObject.FindWithTag("WayPoints").GetComponent<WayPoints>();
            target = WP.wpoints[0];
        }

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
