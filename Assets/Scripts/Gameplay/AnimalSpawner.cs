using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public static int spawnedAnimalCount = 0;
    private void FixedUpdate()
    {
        if (spawnedAnimalCount < 5) {
            SpawnAnimal();        
        }
    }

    private void SpawnAnimal()
    {
        GameObject animal = ObjectPooling.SharedInstance.GetPooledAnimal();
        if (animal != null) {
            //find transsfrom
            float randX = Random.Range(-2.5f, 7.5f);
            float randZ = Random.Range(2f, -12f);
            Vector3 randPos = new Vector3(randX, 8f, randZ);
            animal.transform.position = randPos;
            animal.SetActive(true);
            spawnedAnimalCount++;
        }
    }
}
