using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Nest") {
            Invoke("DestroyAnimal", 0.07f);
        }
    }

    void DestroyAnimal()
    {
        // Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
