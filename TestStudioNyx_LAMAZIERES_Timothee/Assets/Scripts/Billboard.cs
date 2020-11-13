using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform mainCamera;

// Script so that the health bar follow the camera (in case of a moving camera)
    void LateUpdate()
    {
        transform.LookAt(transform.position + mainCamera.position);
    }
}
