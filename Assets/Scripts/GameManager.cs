using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public KeyCode switchKey;
    //Player1
    public Camera mainCamera;
    public Camera cameraFront;

    //Player2
    public Camera player2MainCamera;
    public Camera player2CameraFront;

    private void Start()
    {
        if (gameObject.name == "Vehicle")
        {
            mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
            cameraFront = GameObject.Find("Front Camera").GetComponent<Camera>();
        }

        if (gameObject.name == "Player2")
        {
            player2MainCamera = GameObject.Find("Player2 Main Camera").GetComponent<Camera>();
            player2CameraFront = GameObject.Find("Player2 Front Camera").GetComponent<Camera>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            cameraFront.enabled = !cameraFront.enabled;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            player2MainCamera.enabled = !player2MainCamera.enabled;
            player2CameraFront.enabled = !player2CameraFront.enabled;
        }
    }
}
