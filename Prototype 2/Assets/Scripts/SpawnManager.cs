using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        if (Input.GetKeyDown(KeyCode.S)) {
            Instantiate(animalPrefabs[animalPrefabIndex], spawnPosition, animalPrefabs[animalPrefabIndex].transform.rotation);
        }
    }
}
