using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public static Asteroid pontoasteroid;
    public float distancia;
    public Transform[] pontos;
    public int id;
    public int aleatorio;
    

    public GameObject asteroid;
    void Start()
    {
        InvokeRepeating("instciarasteroid", 3, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void instciarasteroid()
    {
        aleatorio = Random.Range(0, 13);

        id = aleatorio;

        Instantiate(asteroid, pontos[id].position, asteroid.transform.rotation);      
    }
}
