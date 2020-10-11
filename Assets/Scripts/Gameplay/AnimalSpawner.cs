using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    /* GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject(); 
   if (bullet != null) {
     bullet.transform.position = turret.transform.position;
     bullet.transform.rotation = turret.transform.rotation;
     bullet.SetActive(true);*/


    private void FixedUpdate()
    {
        GameObject animal = ObjectPooling.SharedInstance.GetPooledAnimal();
        if(animal != null) {
            //find transsfrom
            float randX = Random.Range(-2.5f , 7.5f);
            float randZ = Random.Range(2f , -12f);
            Vector3 randPos = new Vector3(randX, 8f, randZ);
            animal.transform.position = randPos;
            //animal.transform.rotation = Quaternion.identity;
            animal.SetActive(true);
        }
    }
}
