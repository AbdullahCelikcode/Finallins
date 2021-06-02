using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawners = new GameObject[5];
    public GameObject enemy;
    public int wavenumber = 0;
    public int enemySpawnAmount = 0;
    public int killedenemy = 0;

    void Start()
    {
        StartWave();
        for (int i = 2; i< spawners.Length; i++) 
        {
      spawners[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        
        if (killedenemy >= enemySpawnAmount)
        {
            NextWave();
        }
    }
    private void SpawnZomibe()
    {
        int spawnerId = Random.Range(0,spawners.Length);
        Instantiate(enemy,spawners[spawnerId].transform.position,spawners[spawnerId].transform.rotation);

    }
    private void StartWave()
    {
        wavenumber = 1;
        enemySpawnAmount = 3;
        killedenemy = 0;
        for (int i = 0; i < enemySpawnAmount; i++)
        {
            SpawnZomibe();

        }

    }
    public void NextWave()
    {
        wavenumber++;
        enemySpawnAmount += 1;
        killedenemy = 0;
        for (int i = 0; i < enemySpawnAmount; i++)
        {
            SpawnZomibe();

        }
    }
}
