using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICarta : MonoBehaviour {

	public MCarta carta;

	public Text text_nome;
	public Text text_descricao;

	public Texture2D image_gravura;

	public Text text_vida;
	public Text text_forca;
	public Text text_armadura;
	public Text text_vel_Ataque;
	public Text text_vel_Mov;
	public Text text_alcance;
	public Text text_campo_Visao;

	void Start () {

		text_nome.text = carta.nome;
		text_descricao.text = carta.descricao;

		image_gravura = carta.getImage();

		/*text_vida.text = carta.descricao;
		text_forca.text = carta.descricao;
		text_armadura.text = carta.armadura.ToString();
		text_vel_Ataque.text = carta.vel_Ataque.ToString();
		text_vel_Mov.text = carta.vel_Mov.ToString();
		text_alcance.text = carta.alcance.ToString();
		text_campo_Visao.text = carta.campo_Visao.ToString();*/

	}

}