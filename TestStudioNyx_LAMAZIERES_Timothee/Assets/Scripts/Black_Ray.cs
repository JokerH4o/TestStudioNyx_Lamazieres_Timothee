using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

[ExecuteInEditMode]
public class Black_Ray : MonoBehaviour
{
    public float length = 30f;
    Vector3 position;

    // Update() function draw a black ray on the game object's coordinates for a 0.1f duration using DrawRay function
    void Update()
    {
        position = this.transform.position;
        UnityEngine.Debug.DrawRay(position, this.transform.forward * length, Color.black, duration: 0.1f);
    }
}
