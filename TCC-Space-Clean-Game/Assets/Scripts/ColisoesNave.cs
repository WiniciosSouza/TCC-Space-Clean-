using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisoesNave : MonoBehaviour
{

    public static bool pegouCombustivel;
    // Start is called before the first frame update
    void Start()
    {
        pegouCombustivel = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.collider.tag == "Combustivel")
        {
            Destroy(collision.gameObject);
            pegouCombustivel = true;

            Debug.Log("Combustivel");
        }
        else
        {
            pegouCombustivel = false;
        }
    }
}
