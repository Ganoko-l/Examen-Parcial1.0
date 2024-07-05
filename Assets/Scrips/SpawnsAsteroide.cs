using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsAsteroide : MonoBehaviour
{
   
    public GameObject asteroide;
    public float xPos;
    public float yPos;
    public float zPos;
    public float cooldown;
    private void Start()
    {
        InvokeRepeating("InstaciarAsteroide", 1f, cooldown);   
    }

    void InstaciarAsteroide()
    {
        float posicionRandom = Random.Range(-xPos, xPos);
        Vector3 posicionInstancia = new Vector3(posicionRandom, yPos, zPos);
        Instantiate(asteroide, posicionInstancia, Quaternion.identity);
    }
}
