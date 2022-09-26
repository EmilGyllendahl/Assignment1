using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f; // The speed of wich the characters move
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private PlayerTurn playerTurn;


    private void Jump()
    {
      
        characterBody.AddForce(Vector3.up * 300f); // The characters rigidbody is shot up by the vector3.up value and float value
    }

  

    void Update()
     {
        if (playerTurn.IsPlayerTurn())
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Syns detta meddelande?");
                Jump();
            }
        }

       // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

     }

    
}






// transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);