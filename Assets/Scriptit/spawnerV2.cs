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
        if(allowmove == false && EnemiesToSpawnv2[0].moveonceTrue == true) { StartCoroutine(delayDisable()); }
        if (allowmove == false && EnemiesToSpawnv2[1].moveonceTrue == true) { StartCoroutine(delayDisable()); }
        if (allowmove == false && EnemiesToSpawnv2[2].moveonceTrue == true) { StartCoroutine(delayDisable()); }
        if (allowmove == false && EnemiesToSpawnv2[3].moveonceTrue == true) { StartCoroutine(delayDisable()); }
        if (allowmove == false && EnemiesToSpawnv2[4].moveonceTrue == true) { StartCoroutine(delayDisable()); }

        if (EnemiesToSpawnv2[0].enemyInWorld != null && allowmove == true)
        {
            if(EnemiesToSpawnv2[0].moveonceTrue == true)
            { EnemiesToSpawnv2[0].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[0].enemyInWorld.transform.position, EnemiesToSpawnv2[0].posToSWalkTo, 3 * Time.deltaTime); }
            if(EnemiesToSpawnv2[0].enemyInWorld.transform.position == EnemiesToSpawnv2[0].posToSWalkTo)
            { EnemiesToSpawnv2[0].moveonceTrue = false; }
        }
        if (EnemiesToSpawnv2[1].enemyInWorld != null && allowmove == true)
        {
            if (EnemiesToSpawnv2[1].moveonceTrue == true)
            { EnemiesToSpawnv2[1].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[1].enemyInWorld.transform.position, EnemiesToSpawnv2[1].posToSWalkTo, 3 * Time.deltaTime); }
            if (EnemiesToSpawnv2[1].enemyInWorld.transform.position == EnemiesToSpawnv2[1].posToSWalkTo)
            { EnemiesToSpawnv2[1].moveonceTrue = false; }
        }
        if (EnemiesToSpawnv2[2].enemyInWorld != null && allowmove == true)
        {
            if (EnemiesToSpawnv2[2].moveonceTrue == true)
            { EnemiesToSpawnv2[2].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[2].enemyInWorld.transform.position, EnemiesToSpawnv2[2].posToSWalkTo, 3 * Time.deltaTime); }
            if (EnemiesToSpawnv2[2].enemyInWorld.transform.position == EnemiesToSpawnv2[2].posToSWalkTo)
            { EnemiesToSpawnv2[2].moveonceTrue = false; }
        }
        if (EnemiesToSpawnv2[3].enemyInWorld != null && allowmove == true)
        {
            if (EnemiesToSpawnv2[3].moveonceTrue == true)
            { EnemiesToSpawnv2[3].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[3].enemyInWorld.transform.position, EnemiesToSpawnv2[3].posToSWalkTo, 3 * Time.deltaTime); }
            if (EnemiesToSpawnv2[3].enemyInWorld.transform.position == EnemiesToSpawnv2[3].posToSWalkTo)
            { EnemiesToSpawnv2[3].moveonceTrue = false; }
        }
        if (EnemiesToSpawnv2[4].enemyInWorld != null && allowmove == true)
        {
            if (EnemiesToSpawnv2[4].moveonceTrue == true)
            { EnemiesToSpawnv2[4].enemyInWorld.transform.position = Vector3.MoveTowards(EnemiesToSpawnv2[4].enemyInWorld.transform.position, EnemiesToSpawnv2[4].posToSWalkTo, 3 * Time.deltaTime); }
            if (EnemiesToSpawnv2[4].enemyInWorld.transform.position == EnemiesToSpawnv2[4].posToSWalkTo)
            { EnemiesToSpawnv2[4].moveonceTrue = false; }
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
                EnemiesToSpawnv2[u].moveonceTrue = true;
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
    public bool moveonceTrue=true;
    public GameObject enemyToSpawn, enemyInWorld;
    public Vector3 posToSWalkTo;
}