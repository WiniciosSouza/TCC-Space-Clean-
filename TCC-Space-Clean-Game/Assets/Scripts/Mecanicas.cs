using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mecanicas : MonoBehaviour
{
    [Header("Municao")]
    public static int municaoMaxima = 30;
    public static int municaoAtual = 30;
    public Text textoMunicao, textoMunicao2;

    public static bool recarregar;

    void Start()
    {
        AtualizarTextoMunicao();
        recarregar = false;
    }

    void Update()
    {
        AtualizarMunicao();

    }

    void RecarregarMunicao()
    {
        municaoAtual = municaoMaxima;
        recarregar = false;
        AtualizarTextoMunicao();
        Debug.Log("Municao recarregada. Municao atual: " + municaoAtual);
    }
    void AtualizarMunicao()
    {
        if (GerenciarInfomações.startGame == true)
        {
            if (Input.GetMouseButtonDown(0) && municaoAtual > 0)
            {
                municaoAtual--;
                AtualizarTextoMunicao();
                Debug.Log("Atirou! Municao atual: " + municaoAtual);
            }

            if (municaoAtual == 0)
            {
                Debug.Log("Municao esgotada! Aguardando recarga...");
                recarregar = true;
                Invoke("RecarregarMunicao", 5f);

               
            }
        }
            
    }
    void AtualizarTextoMunicao()
    {
        textoMunicao.text = municaoAtual + "/30";
        textoMunicao2.text = municaoAtual + "/30";
    }
}
