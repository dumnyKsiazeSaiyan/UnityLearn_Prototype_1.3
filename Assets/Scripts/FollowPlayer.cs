using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;

    private Vector3 playerPosition;
    private Vector3 offset;


    private void Start()
    {
        if (gameObject.name == "Main Camera")
            player = GameObject.Find("Vehicle");
        
        else if (gameObject.name == "Player2 Main Camera")
            player = GameObject.Find("Player2");

        else
            Debug.Log("Nieznaleziono gracza");

        playerPosition = player.transform.position;
        offset = transform.position - playerPosition;
    }

    private void Update()
    {
        playerPosition = player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = playerPosition + offset;
    }
}
