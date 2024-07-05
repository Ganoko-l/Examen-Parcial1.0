using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float vel = 10f;
    public float limiteX = 4.3f;


    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        
        Vector3 desplazamiento = new Vector3(movimientoHorizontal, 0, 0) * vel *Time.deltaTime;
        Vector3 posicionActual = transform.position + desplazamiento;
        posicionActual.x = Mathf.Clamp(posicionActual.x, -limiteX, limiteX);
        transform.position = posicionActual;

    }
}
