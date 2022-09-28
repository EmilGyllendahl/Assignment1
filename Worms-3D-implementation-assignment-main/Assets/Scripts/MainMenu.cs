using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{

   private float waituntilstart = 5;
   public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed now");
        
    }

    public void StartGame()
    {
       
        SceneManager.LoadScene("Playsersceen");
    }
}
