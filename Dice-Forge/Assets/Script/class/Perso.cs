using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{
    public string Name { get; set; }
    public int Player { get; set; }
    public Bank ressouce {get;set;}
    public Perso(string name , int player )
    {
        Name = name;
        Player = player;
        ressouce = new Bank(player); 
    }   
    
   
}
