using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlegadaMeta : MonoBehaviour
{
    [SerializeField] private GameObject pantallaFinal;
    [SerializeField] private TextMeshProUGUI textLabelTime;

    private float tiempoDePartida;
    private bool estaJugando = true;

    private void Start()
    {
        if (pantallaFinal != null)
        {
            pantallaFinal.SetActive(false);
        }
    }

    private void Update()
    {
        if (estaJugando)
        {
            tiempoDePartida += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Mover mover = other.GetComponentInParent<Mover>();

        if (mover == null)
        {
            return;
        }

        estaJugando = false;
        mover.enabled = false;

        if (pantallaFinal != null)
        {
            pantallaFinal.SetActive(true);
        }

        if (textLabelTime != null)
        {
            textLabelTime.text = tiempoDePartida.ToString("F2") + " segundos";
        }
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}