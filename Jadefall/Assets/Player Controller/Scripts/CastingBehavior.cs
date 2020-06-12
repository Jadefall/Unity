using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingBehavior : MonoBehaviour
{
    public Rigidbody projectile;
    public float castTime = 4.0f;
    public float velocity = 10f;
    public bool cast;

    void Update()
    {
        castTime -= Time.deltaTime;

        if (castTime <= 0f)
        {
            cast = true;
        }

        if (castTime > 0f)
        {
            cast = false;
        }

        if (cast == true)
        {
            Rigidbody p = Instantiate(projectile, transform.position + (transform.forward * 1), transform.rotation);
            p.velocity = transform.forward * velocity;
            castTime = 2.0f;
            Destroy(gameObject);
        }
    }
}
