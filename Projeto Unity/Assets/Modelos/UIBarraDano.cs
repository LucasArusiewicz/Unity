using UnityEngine;
using UnityEngine.UI;

public class UIBarraDano : MonoBehaviour {

    public Image barraVida;
    public float vel = 0.4f;
    private Image barraDano;

    void Start()
    {
        barraDano = GetComponent<Image>();
    }

    void LateUpdate()
    {

        if (barraVida.fillAmount < barraDano.fillAmount)
        {
            barraDano.fillAmount -= Time.deltaTime;
        }
        else
        {
            barraDano.fillAmount = barraVida.fillAmount;
        }

    }
}
