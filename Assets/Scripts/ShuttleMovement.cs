using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleMovement : MonoBehaviour
{
    public float forwardSpeed = 1.0f; // Velocidad hacia adelante
    public float verticalRotationSpeed = 50.0f; // Velocidad de rotación vertical
    public float rollSpeed = 100.0f; // Velocidad de giro

    void Start()
    {
        // Ocultar el cursor al iniciar el juego
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Rotación hacia arriba (S) o hacia abajo (W)
        float verticalInput = Input.GetAxis("Vertical");
        float verticalRotation = verticalInput * verticalRotationSpeed * Time.deltaTime;
        transform.Rotate(verticalRotation, 0, 0);

        // Rotación en el eje Z con A y D
        float rollInput = Input.GetAxis("Horizontal");
        float rollAmount = rollInput * rollSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rollAmount);
    }
}
