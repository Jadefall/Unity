using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpellBehavior : MonoBehaviour
{
    public Rigidbody explosion;
    public float timer = 5.0f;
    Transform golem;
    private void Start()
    {
        golem = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            attackDamageGolem();
            Destroy(gameObject);
            
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public void attackDamageGolem()
    {
        golem.GetComponent<EnemyAI>().attackDamageGolem();
        print("hoi");
    }
}
