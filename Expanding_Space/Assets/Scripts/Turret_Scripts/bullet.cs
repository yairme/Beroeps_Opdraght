using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{
    private Transform target;

    public int damage;

    public float speed;
    public float Explosion;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    private void Update()
    {
        if (target == null)
        {
            Destroy(this.gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

    private void HitTarget()
    {
        if (Explosion > 0f)
        {
            Explode(transform.position, Explosion);
        }
        else
        {
            Damage(target);
        }
    }

    private void Explode(Vector3 center, float radius)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius);
        foreach (Collider2D collider in hitColliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    private void Damage(Transform enemy)
    {
        Enemy_AI EN = enemy.GetComponent<Enemy_AI>();

        if (EN != null)
        {
            EN.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, Explosion);
    }
}