using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vai ser Utilizado para movimentar o carro pela rua
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
