using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public int cantidad = 50;

    private void OnTriggerEnter(Collider nave)
    {
        if (nave.tag == "Player")
        {
            nave.GetComponent<Vida>().Restarvida(cantidad);
        }
    }
    
}
