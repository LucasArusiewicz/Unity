using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerDeck : MonoBehaviour {

	public MComandante comandante ;
	 
	public float TamanhoPTelaH;
	public float TamanhoPTelaV;
	public float DeltaV;
	public float DeltaH;



	void Start () {

		foreach (MCarta carta in comandante.getDeck()){
			Debug.Log (carta + ": " + carta.nome);
		}
		
	}
	
	

	void OnGUI() {

		int aux = 0;
		
		TamanhoPTelaH = Screen.width/15;
		TamanhoPTelaV = Screen.height/5;
		DeltaV = Screen.height;
		DeltaH = Screen.width/2 - (TamanhoPTelaH*3.5f);

			foreach (MCarta carta in comandante.getDeck()){
				aux ++;

			 if (GUI.Button(new Rect(DeltaH+TamanhoPTelaH*aux,2,TamanhoPTelaH,TamanhoPTelaV)," ")){
				 Debug.Log ("Tropa " + carta.nome + "liberada!");
			 }


			  GUI.Label(new Rect(DeltaH+TamanhoPTelaH*aux,2,TamanhoPTelaH,TamanhoPTelaV), carta.getImage());
			
			}
			 
			
	}
}