using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private GameObject gameManager;
    private NavMeshAgent golem;
    public Animator anim;
    private int spawnerID;

    public float hP;
    public int currentTargetDistance;
    public float lookRadius;

    public Vector3 attack;
    public float enemySpeed;

    private Transform target;
    private Transform playerTarget;
    public float spellDamage;

    void Start()
    {
        gameManager = (GameObject)GameObject.FindWithTag("GameManager");
        golem = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("HOUSE").GetComponent<Transform>();
        playerTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(golem.transform.position, playerTarget.position);
        if (distanceToPlayer < lookRadius)
        {
            attackPlayer();
        }
        else
        {
            dontAttackPlayer();
        }

        transform.LookAt(target);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemySpeed * Time.deltaTime, Space.World);

        float distance = Vector3.Distance(golem.transform.position, target.position);
        if(distance < currentTargetDistance)
        {
            enemySpeed = 0.0f;
            attackMove();
        }
        if (hP <= 0)
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
        gameManager.BroadcastMessage("killGolem", spawnerID);
        Destroy(gameObject);
    }

    public void attackDamageHouse()
    {
        target.GetComponent<HouseHealth>().removeHealth();
        
    }
    public void attackMove()
    {
        anim.SetBool("rightAttack", true);
    }
    public void attackDamagePlayer()
    {
        playerTarget.GetComponent<PlayerHealth>().removeHealth();
    }
    public void attackPlayer()
    {
        anim.SetBool("attackBoth", true);
    }
    public void dontAttackPlayer()
    {
        anim.SetBool("attackBoth", false);
    }
    public void attackDamageGolem()
    {
        hP -= spellDamage;
    }
    public void setName(int sName)
    {
        spawnerID = sName;
    }
}
