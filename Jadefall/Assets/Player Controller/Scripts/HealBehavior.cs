using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBehavior : MonoBehaviour
{
    public Transform playerTarget;

    public void healPlayer()
    {
        playerTarget.GetComponent<PlayerHealth>().addHealth();
    }
}
