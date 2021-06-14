using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    [SerializeField] private Transform target;
    private int wavepointIndex = 0;

    public Transform GetTarget()
    {
        return target;
    }

    public void SetTarget(Transform value)
    {
        target = value;
    }

    void Start()
    {
        Debug.Log("start");
        target = waypoints.points[0];
    }

    void Update ()
    {
        Debug.Log("update!!");
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
        GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        Debug.Log("next wp!!");
        if (wavepointIndex >= waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        SetTarget(waypoints.points[wavepointIndex]);
    }
}
