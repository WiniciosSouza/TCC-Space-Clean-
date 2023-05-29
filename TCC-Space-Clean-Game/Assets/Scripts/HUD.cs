using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("HudVelocimetro")]
    // Transform da seta do velocímetro
    public Transform seta;
    // Valores máximo e mínimo de rotação da seta
    public float rotacaoMaxima = 111.0f;
    public float rotacaoMinima = -111.0f;
    // Velocidade de rotação da seta
    public float velocidadeRotacao = 50.0f;
    // Flag para indicar se o jogador está acelerando
    private bool estaAcelerando = true;
    // Rotação atual da seta
    private float rotacaoAtual = 111.0f;

    [Header("HudCombustivel")]

    public float valorDiminuir = 0.0011f;
    public float maxCombustivel = 1;
    public Image hudDiminuirCombustivel;
    public static float valorCombustivel;
    public float porcetagemCombustivel;

    [Header("HudGameOver")]

    public GameObject telaGameOver;




    private void Start()
    {
        telaGameOver.SetActive(false);
        valorCombustivel = 0f;
    }
    void Update()
    {
        HudVelocimetro();
        HudCombustivel();
        StartCoroutine(TelaGameOver());




    }
    void HudVelocimetro()
    {
        if (GerenciarInfomações.startGame == true)
        {
            // Verifica se o jogador pressionou a tecla espaço
            if (Input.GetKeyDown(KeyCode.Space))
            {
                estaAcelerando = false;


            }

            // Verifica se o jogador soltou a tecla espaço
            if (Input.GetKeyUp(KeyCode.Space))
            {
                estaAcelerando = true;
            }

            // Atualiza a rotação da seta de acordo com a flag estaAcelerando
            if (estaAcelerando)
            {
                rotacaoAtual += velocidadeRotacao * Time.deltaTime;
                rotacaoAtual = Mathf.Clamp(rotacaoAtual, rotacaoMinima, rotacaoMaxima);
            }
            else
            {
                rotacaoAtual -= velocidadeRotacao * Time.deltaTime;
                rotacaoAtual = Mathf.Clamp(rotacaoAtual, rotacaoMinima, rotacaoMaxima);
            }

            // Define a rotação da seta
            seta.rotation = Quaternion.Euler(0.0f, 0.0f, rotacaoAtual);
        }
           
    }

    void HudCombustivel()
    {
        if (GerenciarInfomações.startGame == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                valorDiminuir += 0.0003f;

                Combustivel();
            }
        }

        if(HUD.valorCombustivel == 1)
        {
            rotacaoAtual -= velocidadeRotacao * Time.deltaTime;
            rotacaoAtual = Mathf.Clamp(rotacaoAtual, rotacaoMinima, rotacaoMaxima);

            seta.rotation = Quaternion.Euler(0.0f, 0.0f, rotacaoMaxima);
        }
            
       
    }
    private void Combustivel()
    {
       
        if (ColisoesNave.pegouCombustivel == true)
        {
            valorCombustivel = 0;
        }
        else
        {
            porcetagemCombustivel = (valorDiminuir) / maxCombustivel;

            hudDiminuirCombustivel.fillAmount = (valorDiminuir) / maxCombustivel;


            valorCombustivel = hudDiminuirCombustivel.fillAmount;

        }



    }

    public void GameOver()
    {
        if(HUD.valorCombustivel == 1)
        {
            
            GerenciarInfomações.startGame = false;
        }       
        
    }
    IEnumerator TelaGameOver()
    {
     
        if (HUD.valorCombustivel == 1)
        {
            yield return new WaitForSeconds(2);
            telaGameOver.SetActive(true);
          
        }
    }



}
