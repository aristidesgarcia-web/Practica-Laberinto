using UnityEngine;

public class Encenderobjeto : MonoBehaviour
{
    //bool es una variable que solo vale 0 false o 1 true
    // varible = 3; numero == 4
    // encendido == true / !encendido
    public Material materialEncendido;
    public Material materialApagado;
    bool encendido = false;
    public float cronometro = 5f;
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = materialEncendido;
        encendido = true;
    }
    void Update() {
      if (encendido == true) {
        cronometro = cronometro - Time.deltaTime;
        if (cronometro < 0f) {
            encendido = false;
            GetComponent<MeshRenderer>().material = materialApagado;
            cronometro = 2f;
            }
        }
    }
}
