using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHealth : MonoBehaviour
{
    public int health;

    private void Start()
    {
        health = 500;
    }
    void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void removeHealth()
    {
        health -= 30;
        Debug.Log(health);
    }
}