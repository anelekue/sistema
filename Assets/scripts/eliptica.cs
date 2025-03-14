using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalPlanet : MonoBehaviour
{
    // Objeto alrededor del cual orbitar� el planeta
    public Transform centerObject;

    // Velocidad de rotaci�n en grados por segundo
    public float orbitSpeed = 10f;

    void Update()
    {
        if (centerObject != null)
        {
            // Hacer que el planeta orbite alrededor del objeto central
            transform.RotateAround(centerObject.position, Vector3.up, orbitSpeed * Time.deltaTime);

        }
    }
}