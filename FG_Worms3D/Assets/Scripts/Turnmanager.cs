using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Turnmanager : MonoBehaviour
{
    public int PlayerTurnCounter;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;
    [SerializeField] private GameObject player4;
    public GameObject activePlayer;

    private void Start()
    {
        PlayerTurnCounter = 1;
        activePlayer = player1;
    }
    
    public void ChangeTurn()
    {
        PlayerTurnCounter++;
        Debug.Log(PlayerTurnCounter);
        if (PlayerTurnCounter == 1)
        {
            activePlayer = player1;
        }
        else if (PlayerTurnCounter == 2)
        {
            activePlayer = player2;
        }
        else if (PlayerTurnCounter == 3)
        {
            activePlayer = player3;
        }
        else if (PlayerTurnCounter == 4)
        {
            activePlayer = player4;
            PlayerTurnCounter = 1;
        }

        
    }
}
