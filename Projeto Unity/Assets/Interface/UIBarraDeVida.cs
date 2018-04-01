using UnityEngine;
using UnityEngine.UI;

public class UIBarraDeVida : MonoBehaviour 
{

    private Camera m_MainCamera;

    private Image barra_vida;
    private Image barra_dano;

    private float vida_atual;
    private float vida_maxima;

    private const float DELAY_DANO = 0.3f;

    void Start () 
	{
        m_MainCamera = Camera.main;
        GetComponentes();
    }
	
	void LateUpdate () 
	{
        AtualizaBarras();
        AjustaRotacao();
    }

    private void GetComponentes()
    {
        Image[] imagens = GetComponentsInChildren<Image>();
        barra_dano = imagens[1];
        barra_vida = imagens[2];
    }

    private void AtualizaBarras()
    {
        barra_vida.fillAmount = vida_atual / vida_maxima;

        if (barra_vida.fillAmount < barra_dano.fillAmount)
        {
            barra_dano.fillAmount -= Time.deltaTime * DELAY_DANO;
        }
        else
        {
            barra_dano.fillAmount = barra_vida.fillAmount;
        }
    }

    private void AjustaRotacao()
    {
        Vector3 v = m_MainCamera.transform.position - transform.position;
        v.y = v.z = 0.0f;
        transform.LookAt(m_MainCamera.transform.position - v);
        transform.Rotate(0, 180, 0);
    }

    public void DefineValores(float vida_maxima, float vida_atual)
    {
        this.vida_maxima = vida_maxima;
        this.vida_atual = vida_atual;
    }
}