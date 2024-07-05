using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public int vida = 100;

    public void Restarvida(int cantidad)
    {
        if (vida > 0)
        {
            vida -= cantidad;            
        }

        Muerte();
    }

    public void Muerte()
    {
        if (vida == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
