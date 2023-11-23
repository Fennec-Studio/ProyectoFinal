using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float horizontalSpeed = 2.0f; // Sensibilidad horizontal
    public float verticalSpeed = 2.0f; // Sensibilidad vertical
    public float maxYRotation = 90.0f; // Máxima rotación en Y
    public float minYRotation = -90.0f; // Mínima rotación en Y
    public float maxXRotation = 60.0f; // Máxima rotación en X
    public float minXRotation = -60.0f; // Mínima rotación en X

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        // Obtener la entrada del mouse para el movimiento de la cámara
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        // Rotar la cámara horizontalmente
        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, minYRotation, maxYRotation);

        // Rotar la cámara verticalmente
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minXRotation, maxXRotation);

        // Aplicar la rotación a la cámara
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
