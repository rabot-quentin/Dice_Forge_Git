using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region SINGLETON PATTERN
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("GameManager");
                    _instance = container.AddComponent<GameManager>();
                    container.tag = "GameManager";
                }
            }

            return _instance;
        }
    }
    #endregion
    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;    
    public Camera temples;
    public Camera CamDe;

    public Image perso1;
    public Image perso2;
    public Image perso3;
    public Image perso4;

    public GameObject rouge;
    public GameObject bleu;
    public GameObject noir;
    public GameObject vert;
    public GameObject ZoneDe;
    public GameObject temple;

    public Text Tours;

    public int TourRestante = 10;
    public int Manche = 0;

    public string SceneFinal;   

    public Button Buttontemple;

    public int actuelPlayer { get; set; }
    public List<Perso> persos { get; set;  }

    void Update()
    {
        if (Manche >= 10)
        {
            Debug.Log("fin de partie");
            SceneManager.LoadScene(SceneFinal);
        }
       
    }
     void Start()
     {
        Player1.gameObject.SetActive(true);
        perso1.gameObject.SetActive(true);
        actuelPlayer = 1 ;        
        persos = new List<Perso>() { new Perso("bleu", 1), new Perso("noir", 2) , new Perso("Rouge", 3 ) , new Perso("vert" , 4)}; 
    }

    public void JoueurSuivant()
    {
        Player1.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);
        perso1.gameObject.SetActive(false);
        perso2.gameObject.SetActive(false);
        perso3.gameObject.SetActive(false);
        perso4.gameObject.SetActive(false);
        temple.gameObject.SetActive(false);
        temples.gameObject.SetActive(false);

        switch (actuelPlayer)
        {
            case (1):
                Player2.gameObject.SetActive(true);
                perso2.gameObject.SetActive(true);
                Manche = Manche + 1;                   
                TourRestante = TourRestante - 1;
                Tours.text = "" + TourRestante;
                actuelPlayer = 2;
                FaveurDesDieux();
                
                
                break;
            case (2):

                Player3.gameObject.SetActive(true);
                perso3.gameObject.SetActive(true);
                actuelPlayer = 3;
                FaveurDesDieux();
                
                break;
            case (3):

                Player4.gameObject.SetActive(true);
                perso4.gameObject.SetActive(true);
                actuelPlayer = 4;
                FaveurDesDieux();
               
                break;
            case (4):

                Player1.gameObject.SetActive(true);
                perso1.gameObject.SetActive(true);
                actuelPlayer = 1;
                FaveurDesDieux();
                
                break;
        }

    }
    public void FaveurDesDieux()
    {
        ZoneDe.gameObject.SetActive(true);
        CamDe.gameObject.SetActive(true);
        Player1.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);


    }
    public void Temple()
    {
        temple.gameObject.SetActive(true);
        temples.gameObject.SetActive(true);
       
      

    }
    public void FinTemple()
    {
        temple.gameObject.SetActive(false);
        temples.gameObject.SetActive(false);
       
    }
    
    
}
