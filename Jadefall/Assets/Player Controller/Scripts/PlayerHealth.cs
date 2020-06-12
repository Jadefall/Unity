using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float damagePlayer;

    public void Start()
    {
        health = 100;
    }
    void LateUpdate()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void removeHealth()
    {
        health -= damagePlayer;
        Debug.Log(health);
    }
}
