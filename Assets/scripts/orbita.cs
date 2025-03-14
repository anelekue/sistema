using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotación sobre sí mismo

    void Update()
    {
        // 🔄 Rotación sobre sí mismo en el eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
