using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facehoos : MonoBehaviour
{
    public Color FaceNull;
    private Renderer rend;

    public void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnMouseDown()
    {
        
        rend.material.color = FaceNull;
    }
    

}
