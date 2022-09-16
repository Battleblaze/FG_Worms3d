using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int maxHealth = 150;
    private int health = 150;
    
    [SerializeField] private Healthbar _healthbar;
    
    
    // Start is called before the first frame update
    void Start()
    {
    _healthbar.UpdateHeathBar(maxHealth, health);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            health -= 10;
            _healthbar.UpdateHeathBar(maxHealth, health); 
        }
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
