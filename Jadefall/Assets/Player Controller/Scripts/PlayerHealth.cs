using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
