using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam1;
    public Transform cam2;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam1.forward);
        transform.LookAt(transform.position + cam2.forward);
    }
}
