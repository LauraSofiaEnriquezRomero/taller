using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjeto : MonoBehaviour
{
    public float velocidadRotacion = 10f; // Velocidad de rotación del objeto

    void Update()
    {
        // Rotamos el objeto alrededor del eje Y
        transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f);
    }
}
