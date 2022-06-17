

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Material Mat;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
         Mat = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(UnityEngine.Random.Range(0.1f,40.0f) * Time.deltaTime, 0.0f, 0.0f);
        transform.localScale = Vector3.one * UnityEngine.Random.Range(0.1f,1.5f);
        Mat.color = new Color(UnityEngine.Random.Range(0.1f,1.0f), UnityEngine.Random.Range(0.1f,1.0f), UnityEngine.Random.Range(0.1f,1.0f), UnityEngine.Random.Range(0.1f,1.0f));
    }
}
