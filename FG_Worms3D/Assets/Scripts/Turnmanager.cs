using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Turnmanager : MonoBehaviour
{
    public bool PlayerOneTurn = true;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (PlayerOneTurn == true)
            {
                PlayerOneTurn = false;
            }
            else
            {
                PlayerOneTurn = true;
            }
        }
    }
}
