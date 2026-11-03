using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject puntito;

    private void Update()
    {
        if (transform.position.y < 0f)
        {
            transform.position = puntito.transform.position;
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{other.transform.position = puntito.transform.position;}

}
