using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class MComandante : MonoBehaviour {

    public MCarta[] deck = new MCarta[5];
    public TextAsset historia;
	public Sprite imagem;



	public MCarta[] getDeck(){
		return this.deck;
	}


	public TextAsset getHistoria(){
		return this.historia;
	}


	public Sprite getImagem(){
		return this.imagem;
	}

}