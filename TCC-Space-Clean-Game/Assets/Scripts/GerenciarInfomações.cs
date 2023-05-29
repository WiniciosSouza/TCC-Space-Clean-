using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciarInfomações : MonoBehaviour
{
    public Text informação;

    public GameObject tres;
    public GameObject dois;
    public GameObject um;
    public GameObject missaoIniciada;

    public static bool startGame;

    public GameObject telaGameOver;

    void Start()
    {
   
        StartCoroutine(tempo());
        StartCoroutine(tempoIniciar());

        startGame = false;

    }

   
    void Update()
    {
        InfoCombustivel();
        StartCoroutine(infoMunicoes());

    }
    void InfoCombustivel()
    {
        if (HUD.valorCombustivel >= 1f)
        {
            informação.text = ("" + "" + "Sem Combustivel!!!");
        }
    }
    IEnumerator tempo()
    {
        yield return new WaitForSeconds(4);
        informação.text = ("Missão Iniciada!");
        yield return new WaitForSeconds(5);
        informação.text = ("Recolha os Satelites...");
    }
    IEnumerator tempoIniciar()
    {
        yield return new WaitForSeconds(1);
        tres.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        tres.SetActive(false);
        dois.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        dois.SetActive(false);
        um.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        um.SetActive(false);
        missaoIniciada.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        missaoIniciada.SetActive(false);
        startGame = true;                 
    }
    IEnumerator infoMunicoes()
    {
        if(Mecanicas.recarregar == true)
        {
            informação.text = ("Recarrecando...(5)");
            yield return new WaitForSeconds(1f);
            informação.text = ("Recarrecando...(4)");
            yield return new WaitForSeconds(1f);
            informação.text = ("Recarrecando...(3)");
            yield return new WaitForSeconds(1f);
            informação.text = ("Recarrecando...(2)");
            yield return new WaitForSeconds(1f);
            informação.text = ("Recarrecando...(1)");
            yield return new WaitForSeconds(1f);
            informação.text = ("Munição recarregada");
            yield return new WaitForSeconds(1f);
        }
       
    }
}
