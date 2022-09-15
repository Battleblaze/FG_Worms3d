using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    
    void Update()
    {
        gameObject.transform.position = (new Vector3(player.transform.position.x ,player.transform.position.y + 2,player.transform.position.z -4));
        gameObject.transform.rotation = (new Quaternion(player.transform.rotation.x ,player.transform.rotation.y ,player.transform.rotation.z, player.transform.rotation.w));
    }
    
}
