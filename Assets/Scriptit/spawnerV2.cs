using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerV2 : MonoBehaviour
{
    public bool allowmove = false;
    public Vector3 startingLoc;
    public enemiesToSpawnFromPortal[] EnemiesToSpawnv2;

    void Start()
    {
        startingLoc = this.gameObject.transform.position;
        InvokeRepeating("deadMobTestingLoop", 1, 2);
        StartCoroutine(delayDisable());
    }
    void Update()
    {
        if(allowmove == false) { StartCoroutine(delayDisable()); }

        if (EnemiesToSpawnv2[0].enemyInWorld != null && allowmove == true)
        {
            EnemiesToSpawnv2[0].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[0].enemyInWorld.transform.position, EnemiesToSpawnv2[0].posToSWalkTo, 3 * Time.deltaTime);
        }
        if (EnemiesToSpawnv2[1].enemyInWorld != null && allowmove == true)
        {
            EnemiesToSpawnv2[1].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[1].enemyInWorld.transform.position, EnemiesToSpawnv2[1].posToSWalkTo, 3 * Time.deltaTime);
        }
    }
    public void deadMobTestingLoop()
    {
        for (int u = 0; u < EnemiesToSpawnv2.Length; u++)
        {
            if (EnemiesToSpawnv2[u].enemyInWorld == null)
            {
                EnemiesToSpawnv2[u].enemyInWorld = Instantiate(EnemiesToSpawnv2[u].enemyToSpawn, this.gameObject.transform.position, Quaternion.identity);
                //EnemiesToSpawn[u].mobAlive = true;
            }
        }
    }
    public void moveEnemyToPlace()
    {
        for (int u = 0; u < EnemiesToSpawnv2.Length; u++)
        {
            if (EnemiesToSpawnv2[u].enemyInWorld != null)
            {
                EnemiesToSpawnv2[u].enemyInWorld.gameObject.transform.position = Vector2.MoveTowards(this.gameObject.transform.position, EnemiesToSpawnv2[u].posToSWalkTo, 2 * Time.deltaTime);
                //StartCoroutine(delaywalkdisable());
            }
        }
    }
    IEnumerator delayDisable()
    {
        yield return new WaitForSeconds(1f);
        allowmove = true;
        yield return new WaitForSeconds(5f);
        allowmove = false;
    }
}
[System.Serializable]
public class enemiesToSpawnFromPortal
{
    public GameObject enemyToSpawn, enemyInWorld;
    public Vector3 posToSWalkTo;
}