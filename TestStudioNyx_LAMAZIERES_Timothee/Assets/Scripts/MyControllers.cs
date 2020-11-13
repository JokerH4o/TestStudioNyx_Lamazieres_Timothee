using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyControllers : MonoBehaviour
{
    public float rSpeed = 1;
    public float speed = 1;


    // Update is called once per frame, if the player press one of the four control keys, move or rotate the player according to the input
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, -rSpeed, 0.0f), Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, rSpeed, 0.0f), Space.Self);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, speed), Space.Self);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, -speed), Space.Self);
        }
    }
}
