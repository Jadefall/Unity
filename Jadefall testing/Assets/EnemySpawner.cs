using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    public GameObject golem;
    public Vector3 spawnPoint;

    public int totalGolems;
    public int spawnedGolems;

    public float waveTimer;
    public float timeTillWave;

    public void Wave()
    {
        Instantiate(golem, spawnPoint, Quaternion.identity);
    }

}
