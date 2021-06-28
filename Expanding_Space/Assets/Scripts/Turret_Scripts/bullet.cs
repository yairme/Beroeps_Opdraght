using UnityEngine;

public class bullet : MonoBehaviour {

    private Transform target;
    
    public int damage;

    public float speed;
    public float Explosion;

    public void Seek (Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
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
            Destroy(this.gameObject);
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

   void HitTarget ()
   {
        if (Explosion > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }
   }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, Explosion);
        foreach (Collider Collider in colliders)
        {
            if (Collider.tag == "Enemy")
            {
                Debug.Log("Exploded");
                Damage(Collider.transform);
            }
        }
    }

    void Damage (Transform enemy)
    {
        Enemy_AI EN = enemy.GetComponent<Enemy_AI>();

        if (EN != null)
        {
            EN.TakeDamage(damage);
        }
    }
}
