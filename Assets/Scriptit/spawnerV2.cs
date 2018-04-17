using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerV2 : MonoBehaviour
{

    public enemiesToSpawn[] EnemiesToSpawn;

    void Start()
    {
        InvokeRepeating("deadMobTestingLoop", 1, 2);
    }
    void Update()
    {
    }
    public void deadMobTestingLoop()
    {
        for (int u = 0; u < EnemiesToSpawn.Length; u++)
        {
            if (EnemiesToSpawn[u].enemyInWorld == null)
            {
                EnemiesToSpawn[u].enemyInWorld = Instantiate(EnemiesToSpawn[u].enemyToSpawn, this.gameObject.transform.position, Quaternion.identity);
                //EnemiesToSpawn[u].mobAlive = true;
            }
        }
    }
    public void moveEnemyToPlace()
    {

    }
}
[System.Serializable]
public class enemiesToSpawnFromPortal
{
    public GameObject enemyToSpawn, enemyInWorld;
    public Vector3 posToSWalkTo;
}