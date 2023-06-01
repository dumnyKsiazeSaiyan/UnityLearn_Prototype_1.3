using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50;

    private void Update()
    {
        transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.forward);
    }
}
