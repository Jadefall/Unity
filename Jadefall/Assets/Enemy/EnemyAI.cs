using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent golem;
    public GameObject house;
    public GameObject player;

    public float hP;
    public float attackDamage;
    public float attackRange;
    public int currentTargetDistance;

    public Vector3 attack;
    public float enemySpeed;
    public float golemDistance;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("HOUSE").GetComponent<Transform>();
        
    }
    void Update()
    {
        transform.LookAt(target);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemySpeed * Time.deltaTime, Space.World);

        float distance = Vector3.Distance(golem.transform.position, target.position);
        if(distance < currentTargetDistance)
        {
            attackMove();
        }
    }

    public void golemHP()
    {
        if(hP >= 0)
        {
            Destroy(gameObject);
        }
    }


    public void attackMove()
    {

    }
}
