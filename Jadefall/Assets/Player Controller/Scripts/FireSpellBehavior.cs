using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpellBehavior : MonoBehaviour
{
    public Rigidbody explosion;
    public float timer = 5.0f;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Ground")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
