using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;

    //Player2
    private float player2HorizontalInput;
    private float player2ForwardInput;

    void Update()
    {
        if (gameObject.name == "Vehicle")
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Time.deltaTime * speed * forwardInput * Vector3.forward);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }

        if (gameObject.name == "Player2")
        {
            player2HorizontalInput = Input.GetAxis("Horizontal2");
            player2ForwardInput = Input.GetAxis("Vertical2");
            transform.Translate(Time.deltaTime * speed * player2ForwardInput * Vector3.forward);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * player2HorizontalInput);
        }
    }
}
