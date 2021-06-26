using UnityEngine;

public class bullet : MonoBehaviour {

    public Transform target;
    
    public int damage = 25;

    public float speed = 70f;

    // public GameObject impactEffect;
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
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

   void HitTarget ()
   {
        Damage(target);
        //GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        //Destroy(effectIns, 2f);
   }

    void Damage (Transform enemy)
    {
        Enemy_AI EN = enemy.GetComponent<Enemy_AI>();

        EN.TakeDamage(damage);
    }
}
