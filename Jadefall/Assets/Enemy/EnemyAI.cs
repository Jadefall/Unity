using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent golem;
    public GameObject house;
    public GameObject player;

    public Vector3 attack;
    public float enemySpeed;
    public float golemDistance;

    public int attackRange;
    public int currentTargetDistance;

    private void Update()
    {
        transform.Translate(attack * Time.deltaTime * enemySpeed);
        if (attackRange < currentTargetDistance)
        {
            attackMove();
        }
    }

    public void attackMove()
    {

    }
}
