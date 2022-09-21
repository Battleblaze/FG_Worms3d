using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    [SerializeField] private Transform shootingStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newProjectile = Instantiate(bullet);
        newProjectile.transform.rotation = shootingStartPosition.rotation;
        newProjectile.transform.position = shootingStartPosition.position;
    }
}
