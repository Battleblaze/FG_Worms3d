using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed; 
    [SerializeField] private Rigidbody playerRB1;
    [SerializeField] private Rigidbody playerRB2;
    [SerializeField] private Transform playerTransform1;
    [SerializeField] private Transform playerTransform2; 
    private Turnmanager turnmanager;

    private void Awake()
    {
        turnmanager = gameObject.GetComponent<Turnmanager>();
    }


    private void Update()
    {
         if (turnmanager.PlayerOneTurn == true)
        {
            playerMovement(playerRB1, playerTransform1);
        }
        else
        {
            playerMovement(playerRB2, playerTransform2);
        }
    }

    private void Jump(Rigidbody x)     //Two different ways of doing jumps
    {
        x.AddForce(Vector3.up * 100f);
    }

    private void playerMovement(Rigidbody rb, Transform ts)
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            ts.position += (ts.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(rb);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ts.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ts.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
    
    
}
