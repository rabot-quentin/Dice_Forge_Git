using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchatCarte : MonoBehaviour
{
    int gold;
    int lune;
    int soleil;
    Carte carte;
    int Prix; 

    string nameCarte; 
        
    public Color SelctClor;
    private Color NormalColor;

    public Text achatCarte; 

    private Renderer rende;

    public void Start()
    {
        rende = GetComponent<Renderer>();
        NormalColor = rende.material.color;
        gold = 50;
        Prix = 2; 
    }
    public void OnMouseDown()
    {
        if (Prix <= gold)
        {
            Debug.Log("vous avez acheter une carte ");
            gold = gold - Prix;
            achatCarte.text = "vous avez achter la carte "; 
        }
        else if (Prix >= gold)
        {
            Debug.Log("vous n'avez pas assez de tune ");
            achatCarte.text = "vous n'avaiez pas assez d'argent";
        }
    }
        
    public void OnMouseExit()
    {
        rende.material.color = NormalColor; 
    }
    public void OnMouseEnter()
    {
            rende.material.color = SelctClor;
        
    
    }

}
