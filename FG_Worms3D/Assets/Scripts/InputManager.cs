using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Turnmanager _turnmanager;
    private PlayerManager _playerManager;
    private Gun _gun;
    

    private void Awake()
    {
        _playerMovement = gameObject.GetComponent<PlayerMovement>();
        _turnmanager = gameObject.GetComponent<Turnmanager>();
        _gun = gameObject.GetComponent<Gun>();
    }
    
    void Update()//this update function holds all inputs for the game
    {
        _playerManager = _turnmanager.activePlayer.GetComponent<PlayerManager>();
        if (Input.GetAxis("Vertical") != 0)
        {
            _playerMovement.WalkForward(_turnmanager.activePlayer);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_playerManager.hasJumped == false)
            {
                _playerMovement.Jump(_turnmanager.activePlayer);
                _playerManager.hasJumped = true;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerMovement.RotateLeft(_turnmanager.activePlayer);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerMovement.RotateRight(_turnmanager.activePlayer);
        }
        if (Input.GetMouseButtonDown(0) && _playerManager.activeWeapon1 == true)
        {
            _gun.Shoot(_turnmanager.activePlayer);
        }
        if (Input.GetMouseButtonDown(0) && _playerManager.activeWeapon1 == false)
        {
            _gun.Throw(_turnmanager.activePlayer);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerManager.ChangeWeapon();
        }
    }
}
