using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDeCenas : MonoBehaviour
{
   [SerializeField] private GameObject painelMenuInicial;
   [SerializeField] private GameObject painelOpcoes;
   [SerializeField] private GameObject Fase;

   

    private void Start()
    {
        
    }
    public void Jogar()
   {
     SceneManager.LoadScene(1);
   }

   public void AbrirOpcoes()
   {
    painelOpcoes.SetActive(true);

    painelMenuInicial.SetActive(false);
   }

   public void FecharOpcoes()
   {
     painelOpcoes.SetActive(false);

     painelMenuInicial.SetActive(true);
   }

   public void SairJogo()
   {
     Application.Quit();
   }
    public void AbrirFase()
    {
        Fase.SetActive(true);
    }
    public void FecharAbrirFase()
    {
        Fase.SetActive(false);
    }
    public void PlayFase()
    {
        SceneManager.LoadScene(2);
    }
    public void VoltarTela()
    {
        SceneManager.LoadScene(0);
    }
    public void RecarregarTelaDeFases()
    {
        SceneManager.LoadScene(1);
       

    }

}
