using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSounds : MonoBehaviour
{
    private static RobotSounds instance;

    [SerializeField] private AudioSource audioSource; // Enables the audio from the audio source component.
    [SerializeField] private AudioClip jumpingFX; // AudioClip is not the audio clip, it is a parameter chosen in the inspector/Robot sounds clip.

   

    public RobotSounds GetInstance()
    {
        return instance;
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpingFX);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(jumpingFX);
        }

    
   }
   
}
