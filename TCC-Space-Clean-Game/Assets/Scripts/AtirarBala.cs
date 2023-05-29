using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarBala : MonoBehaviour
{ 
    // Prefab da bala
    public GameObject balaPrefab;
    // Velocidade da bala
    public float velocidadeBala = 30.0f;
    // Objeto de origem do disparo da bala
    public Transform origemBala;
    // Tempo que a bala deve durar
    public float tempoDeVida = 6.0f;

    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi pressionado
        if (GerenciarInfomações.startGame == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Mecanicas.municaoAtual > 0)
                {
                    // Cria uma nova bala a partir do prefab
                    GameObject novaBala = Instantiate(balaPrefab, origemBala.position, Quaternion.identity);

                    // Destrói a bala após o tempoDeVida
                    Destroy(novaBala, tempoDeVida);
                }

            }
        }
        
    }
}
