using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 startPosition;
    public Camera mainCamera;
    private Vector3 playerPosition;
    private Vector3 offset;


    private void Start()
    {

        player = GameObject.Find("Vehicle");
        mainCamera = GetComponent<Camera>();
        startPosition = transform.position;
        offset = startPosition - playerPosition;
    }

    private void Update()
    {
        playerPosition = player.transform.position;

        if (Input.GetKeyDown(KeyCode.F))
        {
            mainCamera.enabled = !mainCamera.enabled;
        }
    }

    private void LateUpdate()
    {
        transform.position = playerPosition + offset;
    }
}
