using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
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
                    c.GetComponent<PlayerHealth>().DoDamage(35);
                    
                }
            }
            
            Destroy(gameObject);
        }
    }
}
