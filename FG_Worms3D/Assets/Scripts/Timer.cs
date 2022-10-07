using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour //This scripts handles a timer that tells when it is time to change turn
{
    public float timeRemaining = 5;
    private Text timer;

    [SerializeField] private GameObject gameManager;

    private Turnmanager _turnmanager;

    private void Start()
    {
        timer = gameObject.transform.Find("Timer").GetComponentInChildren<Text>();
        _turnmanager = gameManager.GetComponent<Turnmanager>();
    }

    private void Update()
    {
        if (timeRemaining <= 0)
        {
            _turnmanager.ChangeTurn();
            timeRemaining = 5;
        }
    }

    void FixedUpdate()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            string time = Convert.ToString(timeRemaining);
            timer.text = time;
        }
    }
}
