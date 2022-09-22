using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 150;
    public int health = 150;
    [SerializeField] private Healthbar _healthbar;
    
    void Start()
    {
    _healthbar.UpdateHealthBar(maxHealth, health);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            health -= 10;
            _healthbar.UpdateHealthBar(maxHealth, health);
        }
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }   
    }

    public void DoDamage(int damange)
    {
        health -= damange;
        _healthbar.UpdateHealthBar(maxHealth, health);
    }

}
