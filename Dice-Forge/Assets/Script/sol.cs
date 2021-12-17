using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sol : MonoBehaviour
{
    public Color hoverColor;
    private Color StartColors;

    private GameObject Piont; 

    private Renderer rend; 

    public void Start()
    {
        rend = GetComponent<Renderer>();
        StartColors = rend.material.color; 

    }
    public void OnMouseEnter()
    {
        rend.material.color = hoverColor; 

    }
    private void OnMouseDown()
    {
        if (Piont != null)
        {
            Debug.Log("y a deja du monde donc faut le viret ");
            return;
        }
    }
    private void OnMouseExit()
    {
        rend.material.color = StartColors; 
    }
}
