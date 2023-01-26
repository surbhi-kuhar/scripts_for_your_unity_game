using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
   
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Vector3 spawPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            Instantiate(animalPrefabs[animalIndex], spawPos, animalPrefabs[animalIndex].transform.rotation);
            
        }
        
    }
}
