using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() {

    }

    private void SpawnRandomAnimal() {
        var animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        Instantiate(animalPrefabs[animalPrefabIndex], spawnPosition, animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
