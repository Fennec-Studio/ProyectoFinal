using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaycastShuttle : MonoBehaviour
{
    [SerializeField] Transform shuttleRaycast;
    public TextMeshPro distanceText;
    public TextMeshPro namePlanet;

    void Update()
    {
        Vector3 shuttleForward = shuttleRaycast.forward;
        RaycastHit hit;
        if (Physics.Raycast(shuttleRaycast.position, shuttleForward, out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Planet"))
            {
                distanceText.text = hit.distance.ToString("F2") + " km";
                namePlanet.text = hit.collider.name;
                return;
            }
        }
        distanceText.text = "---";
        namePlanet.text = "Galaxy";
    }
}
