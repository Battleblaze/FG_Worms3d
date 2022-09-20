using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;

    private void Start()
    {
        speed = 100f;
    }

    private void Update()
    {
        transform.Translate( speed * Time.deltaTime * transform.forward);
    }
}
