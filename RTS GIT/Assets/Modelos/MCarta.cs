using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova Carta", menuName = "Cartas")]



public class MCarta : ScriptableObject {

	public string nome;
	public string descricao;
	public Texture2D gravura;

	public int vida;
	public int forca;
	public int armadura;
	public float vel_Ataque;
	public float vel_Mov;
	public float alcance;
	public float campo_Visao;

    public Material material;

	public void Info()
	{
		Debug.Log (nome + ": " + descricao);
	}



	public Texture2D getImage(){
		return this.gravura;
	}
}