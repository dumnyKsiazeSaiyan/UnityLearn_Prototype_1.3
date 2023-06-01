using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    private Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = plane.transform.position;
        offset = transform.position - playerPosition;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
