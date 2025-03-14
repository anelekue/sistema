using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float speed = 5.0f;          // Velocidad de movimiento
    public float mouseSensitivity = 2.0f; // Sensibilidad del mouse
    public float verticalLimit = 80.0f;  // Límite de la rotación vertical

    private float rotationX = 0f;

    void Update()
    {
        // Movimiento con WASD + Espacio/Ctrl
        float moveX = Input.GetAxis("Horizontal"); // A/D
        float moveZ = Input.GetAxis("Vertical");   // W/S
        float moveY = 0f;

        if (Input.GetKey(KeyCode.Space)) moveY = 1f; // Subir
        if (Input.GetKey(KeyCode.LeftControl)) moveY = -1f; // Bajar

        Vector3 move = transform.right * moveX + transform.up * moveY + transform.forward * moveZ;
        transform.position += move * speed * Time.deltaTime;

        // Rotación con el mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -verticalLimit, verticalLimit);

        transform.localRotation = Quaternion.Euler(rotationX, transform.localRotation.eulerAngles.y + mouseX, 0);
    }
}
