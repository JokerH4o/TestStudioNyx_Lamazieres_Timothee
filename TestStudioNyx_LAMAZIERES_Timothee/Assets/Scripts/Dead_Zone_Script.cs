using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Zone_Script : MonoBehaviour
{
    // Set the spawn in inspector
    public Vector3 spawn = new Vector3(0.34f, 0.4123633f, 0.000105771f);

    // On collision with any objects, move it to the spawn
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = spawn;
    }
}