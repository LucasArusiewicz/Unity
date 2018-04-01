using UnityEngine;

public class MComandante : MUnidade {

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