using UnityEngine;

public class ControleurCamera : MonoBehaviour
{
    public float MouvSpeed = 30f; 
     void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.up * MouvSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * MouvSpeed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * MouvSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MouvSpeed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * MouvSpeed * Time.deltaTime); 
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.back * MouvSpeed * Time.deltaTime);
        }

    }
}
