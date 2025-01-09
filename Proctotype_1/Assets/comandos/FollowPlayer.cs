using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -8.01f); //variavel para a camera seguir o player designado

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   //comando para a camera seguir o player designado
        transform.position = player.transform.position + offset; 
    }
}
