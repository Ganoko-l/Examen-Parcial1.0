using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Rayo;
    public Transform Puntoaparicion;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nuevorayo;
            nuevorayo = Instantiate(Rayo, Puntoaparicion.position, Puntoaparicion.rotation);
        }
    }

}
