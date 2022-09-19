using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    /*public Transform Player;
    public float pLerp = .02f;
    public float rLerp = .01f;
   
    */
    public GameObject player;

     private Vector3 offset = new Vector3(0.02f, 3.78f, -7.17f); // The camera offset which follows the player.


  
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
       /* transform.position = Vector3.Lerp(transform.position, Player.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, Player.rotation, rLerp); */
    }                             
}
