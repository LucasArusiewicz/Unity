using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UIPlayerDeck : MonoBehaviour {

	public MComandante comandante ;
	 
	public float TamanhoPTelaH;
	public float TamanhoPTelaV;
	public float DeltaV;
	public float DeltaH;
	public GameObject canvas;
	public GameObject cartaPrefab;



	void Start () {

       



        foreach (MCarta comandanteCarta in comandante.getDeck()){

			GameObject newCarta = Instantiate(cartaPrefab) as GameObject;
            newCarta.transform.SetParent(canvas.transform, false);
        
            newCarta.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = comandanteCarta.getImage();


        }
		
	}
	
	




	void OnGUI() {
			 
			
	}
}