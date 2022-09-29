using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;
    [SerializeField] private float walkingSpeed = 2f;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float pitchClamp = 90; // Creates a limit for the camera movement so it doesen't rotate around the character 180 degres

   
   
    bool canJump;


    private float yaw = 0.0f; // Angle values decribing values
    private float pitch = 0.0f;

  
    private void OnCollisionEnter(Collision other) // On collisionEnter with the plane or other objects with the tag of "Jumpable" enable the jump input.
    {
        if (other.gameObject.tag == "Jumpable")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other) // When the players are not on the plane or another object with the tag of "Jumpable" disabel the jump input
    {
        if (other.gameObject.tag == "Jumpable")
        {
            canJump = false;
        }
    }

    
   
    private void Start()
    {
        Cursor.visible = false; // Disables the mouse pointer in the game mode.
    }

    private void Jump()
    {

        characterBody.AddForce(Vector3.up * 300f); // The characters rigidbody is shot up by the vector3.up value and float value
    }

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
          

            if (Input.GetKeyDown(KeyCode.Space) & canJump) // If the input is space and fulfills canJump requirement enable jump while on that specific player turn.
            {
                Jump(); // shoots up the rigidbody with a value of 300 float.
            }
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * walkingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World); // Interpreted to the world space with the rotation according to the game world space
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }

            ReadRotationInput();

        }

    }

    private void ReadRotationInput()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp); // - pitchclamp rotates from - 90 to pitchclamp 90 degres

        characterCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f); // we dont want to make the camera go up and down
        
    }
}