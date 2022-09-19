using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    public GameObject player;

     private Vector3 offset = new Vector3(-0.05f, 7.02f, -7.04f); // The camera offset which follows the player.


  
    void LateUpdate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.position = player.transform.position + offset;

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }                             
}

