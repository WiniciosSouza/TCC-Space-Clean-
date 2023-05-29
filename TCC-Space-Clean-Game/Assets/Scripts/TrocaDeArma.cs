using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaDeArma : MonoBehaviour
{
    public GameObject Missel;
    public GameObject Gancho;

    void Start()
    {
        Missel.SetActive(true);
        Gancho.SetActive(false);

    }

    void Update()
    {
        if (GerenciarInfomações.startGame == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Missel.SetActive(!Missel.activeSelf);
                Gancho.SetActive(!Gancho.activeSelf);

            }
        }
            
    }
}
