using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerHealth;
    public string playerName;

    private PlayerUI _playerUI;

    private void Awake()
    {
        _playerUI = GetComponentInChildren<PlayerUI>();
    }

    void Start()
    {
        playerHealth = 150;
    }
    
    public void Damage(int dmg)
    {
        playerHealth -= dmg;
        _playerUI.UpdatePlayerHealth();
    }
}
