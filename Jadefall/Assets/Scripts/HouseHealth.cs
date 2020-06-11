using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHealth : MonoBehaviour
{
    public int health = 500;

    void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}