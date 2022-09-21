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

    private void Start()
    {
        PlayerOneTurn = true;
        player2.GetComponent<Gun>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (PlayerOneTurn == true)
            {
                PlayerOneTurn = false;
                player1.GetComponent<Gun>().enabled = false;//turns off playerones gun
                
                player2.GetComponent<Gun>().enabled = true;//turns on player 2s gun

            }
            else
            {
                PlayerOneTurn = true;
                player1.GetComponent<Gun>().enabled = true;
                
                
                
                player2.GetComponent<Gun>().enabled = false;
            }
        }
    }
}
