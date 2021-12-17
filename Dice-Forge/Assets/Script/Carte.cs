using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte : MonoBehaviour
{
    public int Gold;
    public int Lune;
    public int Soleil;
    public int Gloire;
    public int LimitGold;
    public int LimitLune;
    public int LimitSoleil;
    public int LimitGloire;
    public int Prix { get; set; }  
    public enum Cartes
    {
        LeMarteauduforgeron,
        LAncien,
        LeCoffreDuForgeron,
        HerbeDeProvence,
        LesSabotDargent,
        LesSatyres,
        LesAilesDeLaGardienne,
        LeMinotaure,
        LePasseur,
        LaCasqueDinvisibilité,
        LaPince,
        laMeduse,
        LeMiroirAbyssal,
        Lenigme,
        Lhydre
    }
    public Cartes cartes;
    // Start is called before the first frame update
    void StaLeMarteauduforgeronrt()
    {
        switch (cartes)
        {
            case (Cartes.LeMarteauduforgeron):
                Prix = 1; 
                               
                break;
            case (Cartes.LAncien):
                Prix = 1; 

                break;
            case (Cartes.LeCoffreDuForgeron):
                LimitGold = LimitGold + 4;
                LimitLune = LimitLune + 3;
                LimitSoleil = LimitSoleil + 3;
                Soleil = Soleil - 2 ;
                Prix = 1; 
                break;
            case (Cartes.HerbeDeProvence):
                Prix = 1;
                Gloire = 2;
                Gold = 3; 
                break;
            case (Cartes.LesSabotDargent):
                break;
            case (Cartes.LesSatyres):
                break;
            case (Cartes.LesAilesDeLaGardienne):
                break;
            case (Cartes.LeMinotaure):
                break;
            case (Cartes.LePasseur):
                break;
            case (Cartes.LaCasqueDinvisibilité): 
                break;
            case (Cartes.LaPince):
                break;
            case (Cartes.laMeduse):
                break;
            case (Cartes.LeMiroirAbyssal):
                break;
            case (Cartes.Lenigme):
                break;
            case (Cartes.Lhydre):
                Lune = Lune - 5;
                Soleil = Soleil - 5;
                Gloire = Gloire + 24; 
                break; 
        }
    }   
}
