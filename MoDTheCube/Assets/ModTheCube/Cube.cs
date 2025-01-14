using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private Material material;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 1.3f;

        material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        // Girar em torno do eixo Y e fazer rotações no eixo X
        transform.Rotate(25.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.Rotate(0.0f, 50.0f * Time.deltaTime, 0.0f, Space.World);
    }
}
