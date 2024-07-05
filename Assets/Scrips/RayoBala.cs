using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoBala : MonoBehaviour
{
    public float velocidad;

    private void Update()
    {
        transform.Translate(0, velocidad, 0 * Time.deltaTime);
        
        Destroy(this.gameObject, 5f);
    }

}
