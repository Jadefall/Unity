using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject golem;
    public Vector3 spawnPoint;

    public int noGolems = 0;
    public int spawnedGolems;
    public int maxGolems;

    public List<float> list = new List<float>();
    public float waveTimer;
    public float timeTillWave;
    public float totalWaves;

    public bool spawn;

    private void Update()
    {
        if (spawnedGolems == noGolems)
        {
            wave();
        }
        if (spawnedGolems == maxGolems)
        {
            spawn = false;
        }
    }

    public void wave()
    {
        if (spawn == true)
        {
            if (spawnedGolems == 0)
            {
                if (waveTimer == 0)
                {
                    spawnGolem();
                }
            }
        }
    }

    private void spawnGolem()
    {
        Instantiate(golem, spawnPoint, Quaternion.identity);
        spawnedGolems++;
    }

    public void killGolem()
    {
        spawnedGolems--;
    }
}
