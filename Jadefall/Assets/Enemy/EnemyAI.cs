using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent golem;
    public GameObject house;
    public GameObject player;
    public Animator anim;

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
        golem = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("HOUSE").GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        transform.LookAt(target);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemySpeed * Time.deltaTime, Space.World);

        float distance = Vector3.Distance(golem.transform.position, target.position);
        if(distance < currentTargetDistance)
        {
            enemySpeed = 0.0f;
            attackMove();
            house.GetComponent<HouseHealth>().removeHealth();
        }
        if (hP == 0)
        {
            golemHP();
        }
    }

    public void golemHP()
    {
        enemySpeed = 0.0f;
        anim.SetBool("death", true);
    }
    public void clearGolem()
    {
        Destroy(gameObject);
    }

    public void attackDamageHouse()
    {
        //house.GetComponent<HouseHealth>().removeHealth();
        
    }
    public void attackMove()
    {
        anim.SetBool("rightAttack", true);
    }

}
