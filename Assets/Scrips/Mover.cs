using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    // enteros --> int
    // decimales --> float (f)

    public float velocidad = 0.01f;

    //AND --> &&
    //OR --> || ||| AltGr+1(Encima de la Q)
    //NOT --> ! 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad;
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocidad;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocidad;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * velocidad;
        }
    }
}
