using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverasteroid1 : MonoBehaviour
{
    private Asteroid pontosasteroides;
    public int aleatorio;
    void Start()
    {
        pontosasteroides = FindObjectOfType(typeof(Asteroid)) as Asteroid;

        aleatorio = Random.Range(0, 3);

        if (pontosasteroides.id == aleatorio)
        {
            aleatorio += 1;
        }


       

      
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pontosasteroides.pontos[aleatorio].position, 0.25f);

        transform.Rotate(new Vector3(1, 0, 0));

        if (transform.position == pontosasteroides.pontos[aleatorio].position)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Terra")
        {
            Destroy(gameObject);
            Debug.Log("Colidiu com a TERRA");
        }

        if (collision.collider.tag == "Asteroid")
        {
            Destroy(gameObject);
            Debug.Log("Colidiu com Asteroid");
        }
    }

}

