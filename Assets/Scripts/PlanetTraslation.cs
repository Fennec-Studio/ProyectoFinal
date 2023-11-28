using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTraslation : MonoBehaviour
{
    [SerializeField] Transform planetOrbit;
    [SerializeField] float speedTraslation = 20f;
    private TrailRenderer planetTrail;
    private void Start()
    {
        planetTrail = GetComponent<TrailRenderer>();
    }

    void Update()
    {
        transform.RotateAround(planetOrbit.position, Vector3.up, speedTraslation * Time.deltaTime);
        if(planetTrail != null )
        {
            planetTrail.transform.position = transform.position;
        }
    }
}
