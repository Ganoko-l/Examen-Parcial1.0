using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    public float velocidad;

    private void Update()
    {
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);
    }
}
