using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public List<Transform> spawnerList;
    public Transform spawnPointLoc;
    public GameObject enemyPrefabR;
    public GameObject enemyPrefabB;
    public GameObject enemyPrefabG;
    public float spawnTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        spawnPointLoc = spawnerList[Random.Range(0, spawnerList.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
       int i = Random.Range(1,4);
        switch(i)
        {
            
            case 1:
            GameObject enemyspawnedR = Instantiate(enemyPrefabR, spawnPointLoc.position, spawnPointLoc.rotation);
            Rigidbody enemyspawnR = enemyspawnedR.GetComponent<Rigidbody>();
            break;
            case 2:
            GameObject enemyspawnedB = Instantiate(enemyPrefabB, spawnPointLoc.position, spawnPointLoc.rotation);
            Rigidbody enemyspawnB = enemyspawnedB.GetComponent<Rigidbody>();
            break;
            case 3:
            GameObject enemyspawnedG = Instantiate(enemyPrefabG, spawnPointLoc.position, spawnPointLoc.rotation);
            Rigidbody enemyspawnG = enemyspawnedG.GetComponent<Rigidbody>();
            break;
        }
        
        spawnTime = Random.Range(2, 5);
        spawnPointLoc = spawnerList[Random.Range(0, spawnerList.Count)];
    }
}
