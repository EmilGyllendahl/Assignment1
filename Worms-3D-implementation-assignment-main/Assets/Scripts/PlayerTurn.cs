using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    private int playerIndex;

    public void SetPlayerTurn(int index)
    {
        playerIndex = index; // fetches the playerindex
    }

    public bool IsPlayerTurn() // and if it is the players turn
    {
        return TurnManager.GetInstance().IsItPlayerTurn(playerIndex); // return it to the Turnmanager with the index in the public bool.
    }
}