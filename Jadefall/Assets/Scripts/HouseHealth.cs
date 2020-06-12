using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseHealth : MonoBehaviour
{
    public float health;
    public float damageHouse;

    private void Start()
    {
        health = 500;
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
        health -= damageHouse;
        Debug.Log(health);
    }
}