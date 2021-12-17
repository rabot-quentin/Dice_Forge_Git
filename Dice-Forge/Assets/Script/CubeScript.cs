using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CubeScript : MonoBehaviour
{
    public int face { get; set; }

    public int Force = 200;
    public Camera De;
    public GameObject ZoneDe;
    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;



    Rigidbody rgbd;

    public Text resulta1;
    public Text resulta2;
    private bool LancerDe = false;
    void Start()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && rgbd.velocity.magnitude == 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("gooooooooooooooooo");
                rgbd.AddForce(hit.point * Force);
                LancerDe = true;
            }
        }
    }
    public void Update()
    {
        if (LancerDe && rgbd.velocity.magnitude == 0)
        {
            Debug.Log("yo ");
            LancerDe = false;
            StartCoroutine("AfficherScore");

        }
    }
    IEnumerator AfficherScore()
    {
        if (resulta1 != null)
        {
            resulta1.enabled = true;
            resulta1.text = " " + face;
            yield return new WaitForSeconds(5f);
            Debug.Log("affichage score + retour jeux");
            resulta1.enabled = false;
            ZoneDe.gameObject.SetActive(false);
            De.gameObject.SetActive(false);
            switch (GameManager.Instance.actuelPlayer)
            {
                case (1):
                    Player1.gameObject.SetActive(true);
                    break;
                case (2):
                    Player2.gameObject.SetActive(true);
                    break;
                case (3):
                    Player3.gameObject.SetActive(true);
                    break;
                case (4):
                    Player4.gameObject.SetActive(true);
                    break;

            }
            if (resulta2 != null)
            {
                resulta2.enabled = true;
                resulta2.text = " " + face;
                GameManager.Instance.persos[GameManager.Instance.actuelPlayer - 1].ressouce.PointPlus(1, 1, 1, 1);
                yield return new WaitForSeconds(3f);
                Debug.Log("affichage score + retour jeux");
                resulta2.enabled = false;
                ZoneDe.gameObject.SetActive(false);
                De.gameObject.SetActive(false);
                switch (GameManager.Instance.actuelPlayer)
                {
                    case (1):
                        Player1.gameObject.SetActive(true);
                        break;
                    case (2):
                        Player2.gameObject.SetActive(true);
                        break;
                    case (3):
                        Player3.gameObject.SetActive(true);
                        break;
                    case (4):
                        Player4.gameObject.SetActive(true);
                        break;

                }



            }
        }
    }
} 

