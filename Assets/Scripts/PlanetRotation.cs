using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] float speedRotation = 10.0f;
    
    void Update()
    {
        transform.Rotate(Vector3.up, speedRotation * Time.deltaTime);
    }
}
