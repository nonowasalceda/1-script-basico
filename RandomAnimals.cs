using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimals : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPositionX = 20.0f;
    private float spawnPositionZ = 20.0f;
    private float starAppearAnimals = 2.0f;
    private float timeToRepeatAnimals = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("spawnRandomAnimal",starAppearAnimals,timeToRepeatAnimals);
    }

    // Update is called once per frame
    void Update()
    {

  
    }

    void spawnRandomAnimal()
{
    int animalIndex = Random.Range(0,animalPrefabs.Length);
    Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,spawnPositionZ);

    Instantiate(animalPrefabs[animalIndex],spawnPosition,animalPrefabs[animalIndex].transform.rotation); 
}

}

