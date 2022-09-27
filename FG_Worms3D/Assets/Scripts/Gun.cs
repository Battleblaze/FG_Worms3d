using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject grenade;
    
    public void Shoot(GameObject go)
    {
        Instantiate(bullet,go.transform.GetChild(0).transform.position,go.transform.rotation );
    }
    public void Throw(GameObject go)
    {
        GameObject newProjectile = Instantiate(grenade, go.transform.GetChild(0).transform.position,go.transform.rotation);
        newProjectile.GetComponent<Rigidbody>().AddRelativeForce(0,500,100);
    }
}
