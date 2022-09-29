using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{

    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns;
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    [SerializeField] private GameObject Background;
    [SerializeField] private GameObject healthbar;
    [SerializeField] private GameObject Healtbar2;

    private int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
            cam1.SetActive(true); // Makes it so cam1 is allways set to activate at first when awaking the scene and focusing on teh player it is attached to
            cam2.SetActive(false);
            Background.SetActive(false); // Makes it so the canvas is not shown att awake in players turn. Ii is set to false.
       
        }
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 5; // The timer between turns.
                waitingForNextTurn = false;
                ChangeTurn();
            }
        }
    }

    public bool IsItPlayerTurn(int index)
    {
        if (waitingForNextTurn)
        {
            return false;
        }

        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
    }


    private void ChangeTurn()
    {
        if (currentPlayerIndex == 1) // if the index was of player 1, 
        {
            currentPlayerIndex = 2; // Set it to player 2.
            cam1.SetActive(false);
            cam2.SetActive(true);
            healthbar.SetActive(false);
            Healtbar2.SetActive(true);
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
            cam1.SetActive(true); // Camera 1 is set to be active and used when the currentPlayerInded is 1.
            cam2.SetActive(false);
            healthbar.SetActive(true);
            Healtbar2.SetActive(false);
        }

        
    }
}
