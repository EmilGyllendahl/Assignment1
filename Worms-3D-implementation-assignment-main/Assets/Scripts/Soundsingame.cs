using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsingame : MonoBehaviour
{
    private static Soundsingame instance;

    [SerializeField] private AudioSource audioSource; // Enables the audio from the audio source component.
    [SerializeField] private AudioClip jumpingFX; // AudioClip is not the audio clip, it is a parameter chosen in the inspector/Robot sounds clip.
    [SerializeField] private AudioClip shootinggun;
    [SerializeField] private AudioClip playermovement;

    public Soundsingame GetInstance()
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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSource.PlayOneShot(shootinggun);
        }

        
    
   }
   
}

