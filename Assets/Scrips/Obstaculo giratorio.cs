using UnityEngine;

public class Obstaculogiratorio : MonoBehaviour
{
    public float rotacionY = 10f;
    void Update()
    {
        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f);
    }
}
