using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPlayer : MonoBehaviour
{
    public GameObject rouge;
    public GameObject bleu;
    public GameObject noir;
    public GameObject vert;         

    private void OnMouseDown()
    {
        Debug.Log("deplacement");
        switch (GameManager.Instance.actuelPlayer)
        {
            case (1):
                bleu.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;
            case (2):
                noir.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;
            case (3):
                rouge.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;
            case (4):
                vert.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;
        }               
    }
}
