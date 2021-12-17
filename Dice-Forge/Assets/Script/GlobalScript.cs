 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    public static Transform selectionneur;
    public static Transform selctValidation;
    public static TextMesh NameText; 
    
   
     void Awake()
    {
        selectionneur = GameObject.Find("selectionneur").transform;
        selctValidation = GameObject.Find("selctValidation").transform;
        NameText = GameObject.Find("NamePerso").GetComponent<TextMesh>();

        selectionneur.gameObject.SetActive(false);
        selctValidation.gameObject.SetActive(false);
    }
}
  