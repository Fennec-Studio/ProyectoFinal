using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SatelliteController : MonoBehaviour
{
    [SerializeField] GameObject spaceShuttle;
    [SerializeField] TextMeshProUGUI releaseText;
    private bool parked = false;
    private ShuttleMovement shuttleMovementScript;
    void Start()
    {
        shuttleMovementScript = spaceShuttle.GetComponent<ShuttleMovement>();
        shuttleMovementScript.enabled = false;
        spaceShuttle.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!parked)
            {
                spaceShuttle.transform.parent = null;
                shuttleMovementScript.enabled = true;
                releaseText.enabled = false;
            }
        }
    }
}
