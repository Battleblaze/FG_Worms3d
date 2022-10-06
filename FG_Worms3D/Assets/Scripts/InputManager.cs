using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Turnmanager _turnmanager;
    private Gun _gun;
    

    private void Awake()
    {
        _playerMovement = gameObject.GetComponent<PlayerMovement>();
        _turnmanager = gameObject.GetComponent<Turnmanager>();
        _gun = gameObject.GetComponent<Gun>();
    }
    
    void Update()//this update function holds all inputs for the game
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            _playerMovement.WalkForward(_turnmanager.activePlayer);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerMovement.Jump(_turnmanager.activePlayer);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerMovement.RotateLeft(_turnmanager.activePlayer);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerMovement.RotateRight(_turnmanager.activePlayer);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _gun.Shoot(_turnmanager.activePlayer);
        }
        if (Input.GetMouseButtonDown(1))
        {
            _gun.Throw(_turnmanager.activePlayer);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            _turnmanager.ChangeTurn();
        }
    }
}
