using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
   
    void Start()
    {
    
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
        
    }

    void Update()
    {

        
        
    }
    
    void SpawnRandomAnimal() {
         
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
