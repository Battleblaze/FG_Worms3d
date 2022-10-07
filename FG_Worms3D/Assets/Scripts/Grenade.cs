using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour//Handles the collision and damage of the grenade
{
    [SerializeField] private Transform playerTransform;
    private bool collided = false;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collided == false)
        {
            collided = true;


            Collider[] collisions = Physics.OverlapSphere(gameObject.transform.position, 5f);
            foreach (var c in collisions)
            {
                if (c.CompareTag("Player"))
                {
                    c.GetComponent<PlayerManager>().Damage(35);
                    
                }
            }
            
            Destroy(gameObject);
        }
    }
}
