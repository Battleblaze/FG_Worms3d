using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Turnmanager : MonoBehaviour
{
    public bool PlayerOneTurn;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    public GameObject activePlayer;
    private PlayerManager _playerManager;


    private void Start()
    {
        activePlayer = player1;
    }
    
    public void ChangeTurn()
    {
        if (PlayerOneTurn == true)
        {
            _playerManager = activePlayer.GetComponent<PlayerManager>();
            _playerManager.hasJumped = false;

            activePlayer = player1;
            PlayerOneTurn = false;
        }
        else
        {
            _playerManager = activePlayer.GetComponent<PlayerManager>();
            _playerManager.hasJumped = false;
            
            activePlayer = player2;
            PlayerOneTurn = true;
        }

        
    }
}
