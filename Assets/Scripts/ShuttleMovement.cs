using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleMovement : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 1.0f;
    [SerializeField] float verticalRotationSpeed = 50.0f;
    [SerializeField] float rollSpeed = 100.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
           transform.Translate(Vector3.forward * forwardSpeed * 20 * Time.deltaTime);
        } else
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }
        //transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        float verticalInput = Input.GetAxis("Vertical");
        float verticalRotation = verticalInput * verticalRotationSpeed * Time.deltaTime;
        transform.Rotate(verticalRotation, 0, 0);
        float rollInput = Input.GetAxis("Horizontal");
        float rollAmount = rollInput * rollSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rollAmount);
    }
}
