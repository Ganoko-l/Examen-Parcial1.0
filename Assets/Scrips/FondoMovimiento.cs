using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    public float velocidad = 0.5f;

    private void Update()
    {
        float offset = Time.time * velocidad;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offset);
    }
}
