using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidadeAvanco = 25f;
    public float velocidadeHorizontal = 7.5f;
    public float velocidadeVertical = 10f;

    private float ativarVelociadeAvanco, ativarVelocidadeHorizontal, ativarVelocidadeVertical;

    private float avancoAceleração = 2.5f;
    private float horizontalAceleração = 2f;
    private float verticalAceleração = 2f;

    public float velocidadeRotacao = 30f;

    private Vector2 lookInput;
    private Vector2 centroTela;
    private Vector2 distanciaMause;





    void Start()
    {
        centroTela.x = Screen.width * 0.5f;
        centroTela.y = Screen.height * 0.5f;
    }

    void Update()
    {
       
        Combustivel();
        MoverNave();
       
    }
    void MoverNave()
    {
        if (GerenciarInfomações.startGame == true)
        {

            lookInput.x = Input.mousePosition.x;
            lookInput.y = Input.mousePosition.y;


            distanciaMause.x = (lookInput.x - centroTela.x) / centroTela.x;
            distanciaMause.y = (lookInput.y - centroTela.y) / centroTela.y;

            transform.Rotate(-distanciaMause.y * velocidadeRotacao * Time.deltaTime, -distanciaMause.x * velocidadeRotacao * Time.deltaTime, 0f, Space.Self);

            ativarVelociadeAvanco = Mathf.Lerp(ativarVelociadeAvanco, Input.GetAxisRaw("Vertical") * velocidadeAvanco, avancoAceleração * Time.deltaTime);
            ativarVelocidadeHorizontal = Mathf.Lerp(ativarVelocidadeHorizontal, Input.GetAxisRaw("Horizontal") * -velocidadeHorizontal, horizontalAceleração * Time.deltaTime);
            ativarVelocidadeVertical = Mathf.Lerp(ativarVelocidadeVertical, Input.GetAxisRaw("Flutuar") * velocidadeVertical, verticalAceleração * Time.deltaTime) * 1.01f;

            transform.position += transform.forward * ativarVelociadeAvanco * Time.deltaTime;
            transform.position += (transform.right * ativarVelocidadeHorizontal * Time.deltaTime) + (transform.up * ativarVelocidadeVertical * Time.deltaTime);

        }

    }   
    void Combustivel()
    {
        if (HUD.valorCombustivel >= 1f)
        {

            Debug.Log("Sem Combustivel");

            

            velocidadeAvanco = 0f;
            velocidadeHorizontal = 0f;
            velocidadeVertical = 0f;

            avancoAceleração = 0f;
            horizontalAceleração = 0f;
            verticalAceleração = 0f;

            ativarVelociadeAvanco = 0f;
            ativarVelocidadeHorizontal = 0f;
            ativarVelocidadeVertical = 0f;

            velocidadeRotacao = 5f;
          
        }
    }
    

}
