using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour
{
    public int vida;
    public void Danio(int cantidad)
    {
        vida -= cantidad;
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }    
         
    }

    private void OnTriggerEnter(Collider destruir)
    {
        if (destruir.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }

        if (destruir.gameObject.CompareTag("Rayo")) 
        {
            Debug.Log("Si esta pegando");

            Destroy(this.gameObject);
        }
    }
}
