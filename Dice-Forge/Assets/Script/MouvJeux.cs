using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvJeux : MonoBehaviour
{
   

    // Update is called once per frame
    
        public float MouveSpeed = 30f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.up * MouveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * MouveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * MouveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MouveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        { 
            transform.Translate(Vector3.forward * MouveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.back * MouveSpeed * Time.deltaTime);
        }

    }
}

