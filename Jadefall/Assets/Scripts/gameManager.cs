using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject golem;
    public Vector3 spawnPoint;
    public Vector3 spawnPoint2;
    public Vector3 spawnpoint3;
    public Vector3 spawnpoint4;
    public Vector3 spawnpoint5;

    public int totalGolems = 10;
    public int numGolems = 0;
    public int spawnedGolems = 0;

    private int SpawnID;

    public float numWaves;
    public float totalWaves;
    public float timeTillNextEnemy;

    private bool waveSpawn = false;
    public bool spawn = true;

    void Start()
    {

    }
    void Update()
    {
        timeTillNextEnemy -= Time.deltaTime;






        if (spawn)
        {
            if (numWaves < totalWaves + 1)
            {
                if (waveSpawn)
                {
                    if (timeTillNextEnemy < 0)
                    {
                        spawnGolem();
                        timeTillNextEnemy = 2;

                    }
                }
                if (spawnedGolems == 0)
                {
                    waveSpawn = true;
                    numWaves++;
                }
               if (spawnedGolems == totalGolems)
                {
                    waveSpawn = false;
                }
            }
        }
    }


    private void spawnGolem()
    {
        Vector3 spawnPoint = new Vector3(172, 56,Random.Range(74, 36));
        Instantiate(golem, spawnPoint, Quaternion.identity);
        numGolems++;
        spawnedGolems++;
    }
    public void killGolem(int sID)
    {
        if (SpawnID == sID)
        {
            spawnedGolems--;
        }
    }
    public void enableSpawner(int sID)
    {
        if (SpawnID == sID)
        {
            spawn = true;
        }
    }
    public void disableSpawner(int sID)
    {
        if (SpawnID == sID)
        {
            spawn = false;
        }
    }
}
