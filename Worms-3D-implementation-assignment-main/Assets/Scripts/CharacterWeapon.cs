using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private float Bulletspeed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            bool IsPlayerTurn = playerTurn.IsPlayerTurn();
            if (IsPlayerTurn)
            {
                Vector3 force = transform.forward * Bulletspeed;
                              
                {
                    TurnManager.GetInstance().TriggerChangeTurn();

                    GameObject newProjectile = Instantiate(projectilePrefab, shootingStartPosition.position, shootingStartPosition.rotation);
                    
                    newProjectile.GetComponentInChildren<Projectile>().Initialize(force); // (force)
                }

            }
      
        
        }

         
    }


}