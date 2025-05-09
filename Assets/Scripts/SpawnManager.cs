using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //connects prefabs
    private float spawnRangeX = 20; //range
    private float spawnPosZ = 20; //position
    private float startDelay = 2; //starting delay
    private float spawnInterval = 1.5f; //intervals between spawns
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //causes random animals to continously spawn
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //spawns animal
    void SpawnRandomAnimal()
    {
        //Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
