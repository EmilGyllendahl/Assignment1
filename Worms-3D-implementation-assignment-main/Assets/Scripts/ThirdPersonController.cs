using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;
    [SerializeField] private float walkingSpeed = 2f;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private PlayerTurn playerTurn;


    private float yaw = 0.0f; // Angle values decribing values
    private float pitch = 0.0f;

    [SerializeField] private float pitchClamp = 90; // Creates a limit for the camera movement so it doesen't rotate around the character 180 degres

    private void Jump()
    {

        characterBody.AddForce(Vector3.up * 500f); // The characters rigidbody is shot up by the vector3.up value and float value
    }

   
    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
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