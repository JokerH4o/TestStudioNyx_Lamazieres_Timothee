using UnityEngine;
using System.Collections;

// Define camera position
public class CameraScript : MonoBehaviour
{
    public void CutToShot()
    {
        Camera.main.transform.localPosition = transform.position;
        Camera.main.transform.localRotation = transform.rotation;
    }
}