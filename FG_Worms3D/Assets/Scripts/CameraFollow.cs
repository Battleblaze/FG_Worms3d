using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform Playertransform1;
    [SerializeField] private Transform Playertransform2;//Assigning a playertransform
    private Vector3 _cameraOffset;
    [SerializeField] private float smoothFactor = 0.01f;

    [SerializeField] private float rotationSpeed = 5.0f;
    [SerializeField] private GameObject gamemanager;

    private Turnmanager turnManager;

    private void Awake()
    {
        turnManager = gamemanager.GetComponent<Turnmanager>();
    }

    private void Start()
    {
        _cameraOffset = transform.position - Playertransform1.position;//assigning the offset
    }

    //Lateupdate instead of of update beacasue we want to follow what have changed position in another update function
    void LateUpdate()
    {
        if (turnManager.PlayerOneTurn == true)
        {
            CameraFollowPlayer(Playertransform1);
        }
        else
        {
            CameraFollowPlayer(Playertransform2);
        }
    }

    private void CameraFollowPlayer(Transform ts)
    {
        Vector3 newPos = ts.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor); //moves the cameras position to follow the player position with the smoothfactor

        Quaternion camturnAngleX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
        //Quaternion camturnAngleY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * rotationSpeed, Vector3.right);

        _cameraOffset = camturnAngleX * _cameraOffset ;

        transform.LookAt(ts);//makes the camera look at the player
    }
    
    
}
