using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{

    private Transform target;
    public float range = 15f;

    public string enemyTag = "Enemy";

    public Transform PartToRotate;
    public float turnspeed = 10f;

    // Start is called before the first frame update
    public void Start()
    { 
      InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    // Update is called once per frame
    public void UpdateTarget ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float ShortestDistance = Mathf.Infinity;

        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < ShortestDistance)
            {
                ShortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && ShortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update ()
    {
        if (target == null)
            return;
        //target lock on
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(PartToRotate.rotation, lookRotation,Time.deltaTime * turnspeed).eulerAngles;
        PartToRotate.rotation = Quaternion.Euler(0f, 0f, rotation.z);
        
    }
    public void OnDrawGizmoSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
