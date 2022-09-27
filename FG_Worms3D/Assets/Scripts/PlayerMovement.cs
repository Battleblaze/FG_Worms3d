using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed;
    
    public void Jump(GameObject x)     //Two different ways of doing jumps
    {
        x.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f);
    }
    
    public void WalkForward(GameObject go)
    {
        go.transform.position += (go.transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
    }

    public void RotateRight(GameObject go)
    {
        go.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void RotateLeft(GameObject go)
    {
        go.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }


}
