using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    private static ObjectPooling _instance;
    public static ObjectPooling SharedInstance { get { return _instance; } }

    public GameObject[] animalsToPool;
    [HideInInspector]
    public List<GameObject> pooledAnimals;
    public int animalCount;

    private void Awake()
    {
        // Singleton Pattern
        if (_instance != null && _instance != this)
            Destroy(gameObject);
        else
            _instance = this;

        pooledAnimals = new List<GameObject>();
        for (int i = 0; i < animalsToPool.Length; i++) {
            for (int j = 0; j < animalCount; j++) {
                GameObject obj = Instantiate(animalsToPool[i]);
                pooledAnimals.Add(obj);
                obj.transform.parent = transform;
            }
        }
    }
}
