using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour
{
    public int Gold { get; set; }
    public int Lune { get; set; }
    public int Soleil { get; set; }
    public int Gloire { get; set; }

    public enum Faces
    {
        gold1,
        gold3,
        gold4,
        gold6,
        lune1,
        lune2,
        feu1,
        feu2,
        gloir2,
        gloir3,
        gloir4,
        G1ouL1ouF1,
        G2etL1,
        Gl1etF1,
        g3oul2,
        G1etF1etL1etGl1,
        G2ouF2ouL2,
        Gl2etL2
    }

    public Faces faces;

    void Start()
    {
        switch (faces)
        {
            case (Faces.gold1):
                Gold = +1;
                break;
            case (Faces.gold3):
                Gold = +3;
                break;
            case (Faces.gold4):
                Gold = +4;
                break;
            case (Faces.gold6):
                Gold = +6;
                break;
            case (Faces.lune1):
                Lune = +1;
                break;
            case (Faces.lune2):
                Lune = +2;
                break;
            case (Faces.feu1):
                Soleil = +1;
                break;
            case (Faces.feu2):
                Soleil = +2;
                break;
            case (Faces.gloir2):
                Gloire = +2;
                break;
            case (Faces.gloir3):
                Gloire = +3;
                break;
            case (Faces.gloir4):
                Gloire = +4;
                break;
            case (Faces.G1ouL1ouF1):
                Gold = +1;
                Lune = +1;
                Soleil = +1;
                break;
            case (Faces.G2etL1):
                Gold = +2;
                Lune = +1;
                break;
            case (Faces.Gl1etF1):
                Gloire = +1;
                Soleil = +1;
                break;
            case (Faces.g3oul2):
                Gold = +3;
                Gloire = +2;
                break;
            case (Faces.G1etF1etL1etGl1):
                Gold = +1;
                Gloire = +1;
                Lune = +1;
                Soleil = +1;
                break;
            case (Faces.G2ouF2ouL2):
                Gold = +2;
                Soleil = +2;
                Lune = +2;
                break;
            case (Faces.Gl2etL2):
                Gloire = +2;
                Lune = +2;
                break;


        }
    }

}
