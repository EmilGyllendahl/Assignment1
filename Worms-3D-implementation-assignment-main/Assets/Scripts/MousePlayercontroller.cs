using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MousePlayercontroller : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;


    void Update()
    {
        if (Input.GetMouseButton(0)) // Left mouse button clicked (0))
        {
            RaycastHit result; // Return result of Raycasthit
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // the Camera makes the mosuse click visible on the camera view when the agentobject is moving there.
            if (Physics.Raycast(ray, out result, 100.0f))
            {
                agent.SetDestination(result.point); // Sets the destination for the agent and makes it move there.
            }
        }
    }
}
