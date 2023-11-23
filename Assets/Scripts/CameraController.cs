using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float horizontalSpeed = 2.0f; // Sensibilidad horizontal
    public float verticalSpeed = 2.0f; // Sensibilidad vertical
    public float maxYRotation = 90.0f; // M�xima rotaci�n en Y
    public float minYRotation = -90.0f; // M�nima rotaci�n en Y
    public float maxXRotation = 60.0f; // M�xima rotaci�n en X
    public float minXRotation = -60.0f; // M�nima rotaci�n en X

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        // Obtener la entrada del mouse para el movimiento de la c�mara
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        // Rotar la c�mara horizontalmente
        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, minYRotation, maxYRotation);

        // Rotar la c�mara verticalmente
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minXRotation, maxXRotation);

        // Aplicar la rotaci�n a la c�mara
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
