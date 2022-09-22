using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject enemy;
    private float speed;
    [SerializeField] private GameObject player;
    [SerializeField] private Healthbar _healthbar;
    

    private void Start()
    {
        speed = 100f;
    }

    private void Update()
    {
        transform.Translate( speed * Time.deltaTime * player.transform.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().DoDamage(10);
        }
        Destroy(gameObject);
    }
}
