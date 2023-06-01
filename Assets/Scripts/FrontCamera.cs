using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCamera : MonoBehaviour
{
    public GameObject player;
    public Camera cameraFront;
    private Vector3 startPosition;
    private Vector3 playerPosition;
    private Vector3 offset;


    private void Start()
    {

        player = GameObject.Find("Vehicle");
        cameraFront = GetComponent<Camera>() ;
        startPosition = transform.position;
        offset = startPosition - playerPosition;

    }

    private void Update()
    {
        playerPosition = player.transform.position;

        if (Input.GetKeyDown(KeyCode.F))
        {
            cameraFront.enabled = !cameraFront.enabled;
        }
    }

    private void LateUpdate()
    {
        transform.position = playerPosition + offset;
    }

}
