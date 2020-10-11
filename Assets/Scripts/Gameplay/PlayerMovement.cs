using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    private float playerSpeed = 6f;


    void Update()
    {
        float horizantal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizantal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.01f) {
            controller.Move(direction * playerSpeed * Time.deltaTime);
        }

    }

    
}
