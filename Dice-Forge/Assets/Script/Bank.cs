using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public int Gold { get; set;  } 
    public int Lune { get; set; }
    //lune correspond au fragment de lune 
    public int Soleil { get; set; }
    // soleil correspond au framgment solaire 
    public int Gloire { get; set; } 
    // gloire correspond au point de gloire 
    
   public Bank(int Player )
    {
        switch(Player)
        {
            case 0:
                Gold = 3;
                Lune = 0;
                Soleil = 0;
                Gloire = 0; 
                break;
            case 1:
                Gold = 2;
                Lune = 0;
                Soleil = 0;
                Gloire = 0;
                break;
            case 2:
                Gold = 1;
                Lune = 0;
                Soleil = 0;
                Gloire = 0;
                break;
            case 3:
                Gold = 4;
                Lune = 0;
                Soleil = 0;
                Gloire = 0;
                break;
        }
    }
    public void PointPlus(int gold , int lune , int soleil , int gloire)
    {
        Gold = Gold + gold;
        Lune = Lune + lune;
        Soleil = Soleil + soleil;
        Gloire = Gloire + gloire; 

    }
    public void PointMoin(int gold, int lune, int soleil, int gloire)
    {
        Gold = Gold - gold;
        Lune = Lune - lune;
        Soleil = Soleil - soleil;
        Gloire = Gloire - gloire;
    }
    
}
