using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBala : MonoBehaviour
{
   // Velocidade do objeto
   public float velocidade = 5.0f;

   // Objeto que deve ser seguido
   public GameObject objetoASeguir;

  void Update()
 {
    // Calcula a posição atual do objeto e a posição para onde ele deve se deslocar
    Vector3 posicaoAtual = transform.position;
    Vector3 posicaoDestino = objetoASeguir.transform.position;

       

        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        
 }
}

