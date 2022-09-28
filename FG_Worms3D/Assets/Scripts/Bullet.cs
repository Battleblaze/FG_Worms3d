using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    [SerializeField] private GameObject player;
    private PlayerManager _playerManager;
    [SerializeField] private int damage;
    
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
        _playerManager = other.GetComponent<PlayerManager>();
        if (other.CompareTag("Player"))
        {
            _playerManager.Damage(damage);
        }
        Destroy(gameObject);
    }
}
