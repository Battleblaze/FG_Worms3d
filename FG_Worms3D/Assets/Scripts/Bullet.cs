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
        transform.Translate( speed * Time.deltaTime * player.transform.right);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().health -= 10;
            //_healthbar.UpdateHealthBar(150f,other.GetComponent<PlayerHealth>().health);
        }
        Destroy(gameObject);
    }
}
