using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gasolina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {     

        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Combustivel");
        }
    }
}
