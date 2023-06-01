using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    [SerializeField] private float speed = 15;
    void Update()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.forward);
    }
}
