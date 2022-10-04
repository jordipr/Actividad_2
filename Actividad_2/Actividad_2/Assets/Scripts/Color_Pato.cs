using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Pato : MonoBehaviour
{
    public Color color;
    public MeshRenderer meshRenderer;
  
    void Start()
    {
        meshRenderer.material.color = color;

    }

   
    void Update()
    {
        
    }
}
