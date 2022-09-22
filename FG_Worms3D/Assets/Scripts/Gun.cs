using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject grenade;

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

        if (Input.GetMouseButtonDown(1))
        {
            Throw();
        }
    }

    private void Shoot()
    {
        GameObject newProjectile = Instantiate(bullet);
        newProjectile.transform.rotation = shootingStartPosition.rotation;
        newProjectile.transform.position = shootingStartPosition.position;
    }
    private void Throw()
    {
        GameObject newProjectile = Instantiate(grenade, shootingStartPosition.position,shootingStartPosition.rotation);
        newProjectile.GetComponent<Rigidbody>().AddRelativeForce(0,500,100);
        //newProjectile.transform.rotation = shootingStartPosition.rotation;
        //newProjectile.transform.position = shootingStartPosition.position;
    }
}
