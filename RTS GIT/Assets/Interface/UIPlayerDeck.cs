using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UIPlayerDeck : MonoBehaviour {

	public MComandante comandante ;
	public GameObject panelCartas;
	public GameObject cartaPrefab;
    public GameObject PanelTropaSpawned;
	public GameObject UITropa;

    private ArrayList cartasEventos = new ArrayList();

    

    void Start () {

        foreach (MCarta comandanteCarta in comandante.getDeck()){

			GameObject newCarta = Instantiate(cartaPrefab) as GameObject;
            newCarta.transform.SetParent(panelCartas.transform, false);
            newCarta.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = comandanteCarta.getImage();



            Button buttonCtrl = newCarta.transform.GetChild(1).gameObject.GetComponent<Button>();
            buttonCtrl.onClick.AddListener(() => criaUI_Tropa(comandanteCarta.getImage()));

            cartasEventos.Add(buttonCtrl);


          


        }
		
	}

    public void criaUI_Tropa(Sprite a )
    {
        GameObject Tropa = Instantiate(UITropa) as GameObject;
        Tropa.transform.SetParent(PanelTropaSpawned.transform, false);
        Tropa.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = a;
    }

    private void FixedUpdate()
    {
        
    }



}