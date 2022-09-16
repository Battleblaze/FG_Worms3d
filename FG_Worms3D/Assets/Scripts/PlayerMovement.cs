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
    
    

    
    private void Jump()     //Two different ways of doing jumps
    {
        playerRB1.AddForce(Vector3.up * 100f);
    }

    private void player1Movement()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.position += (transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
    
}
