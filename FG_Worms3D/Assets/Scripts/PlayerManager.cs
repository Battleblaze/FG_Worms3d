using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerHealth;
    public string playerName;
    public bool hasJumped;
    public bool activeWeapon1;

    [SerializeField] private GameObject gameMangager;
    [SerializeField] private GameObject canvas;

    private PlayerUI _playerUI;

    private void Awake()
    {
        _playerUI = GetComponentInChildren<PlayerUI>();
        playerHealth = 150;
        hasJumped = false;
        activeWeapon1 = true;
        
    }

    private void Update()
    {
        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);

            gameMangager.GetComponent<InputManager>().enabled = false;
            canvas.GetComponent<Timer>().enabled = false;

        }
    }


    public void Damage(int dmg)
    {
        playerHealth -= dmg;
        _playerUI.UpdatePlayerHealth();
    }


    public void ChangeWeapon()
    {
        if (activeWeapon1 == true)
        {
            activeWeapon1 = false;
        }
        else
        {
            activeWeapon1 = true;
        }
    }
}
