using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAsteroid : MonoBehaviour
{

    public GameObject objToInstantiate;

    public float xPos, yPos, zPos;

    public float xMovement, yMovement, zMovement;

    public int PminX, PmaxX, PminY, PmaxY, PminZ, PmaxZ;

    public int RminX, RmaxX, RminY, RmaxY, RminZ, RmaxZ;

   

    void Start()
    {
        
    }

    
    void Update()
    {
        InstaciarAsteroid();
    }
    void InstaciarAsteroid()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            Instantiate(objToInstantiate, new Vector3(Random.Range(PminX, PmaxX), Random.Range(PminY, PmaxY), Random.Range(PminZ, PmaxZ)), Quaternion.identity);

            transform.Translate(xMovement, yMovement, zMovement);
        }

        
    }
}
