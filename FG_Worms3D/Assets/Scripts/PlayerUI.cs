using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    private PlayerManager _playerManager;
    private Text textName;
    private Text health;
    
    void Awake()
    {
        _playerManager = GetComponentInParent<PlayerManager>();
    }

    private void Start()
    {
        textName = GetComponentInChildren<Text>();
        health = gameObject.transform.Find("Health").GetComponentInChildren<Text>();
        UpdatePlayerHealth();
        UpdatePlayerName();
    }

    private void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }

    public void UpdatePlayerName()
    {
        textName.text = _playerManager.playerName;
    }

    public void UpdatePlayerHealth()
    {
        string hp = Convert.ToString(_playerManager.playerHealth);
        health.text = hp;
    }
}
