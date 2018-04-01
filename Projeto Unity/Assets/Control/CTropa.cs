using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTropa : MonoBehaviour {

    private Vector2 CaixaSelecaoInicialMouse;
    private Vector2 CaixaSelecaoFinalMouse;

    public Texture2D selecaoTextura;

    private static List<MTropa> tropas; // tropas da cena
    public Camera mainCamera;

    private MTropa[] tropasSelecionadas; //Tropas selecionadas

    void Awake(){

        tropas = new List<MTropa>();
        tropasSelecionadas = new MTropa[0];
    }


    public static void adicionaTropa(MTropa tropa){
        tropas.Add(tropa);

    }


    public MTropa[] GetTropasSelecionadas(Rect selecao){

        List<MTropa> tropasSelecionadas = new List<MTropa>();

        foreach (MTropa tropa in tropas){
            Vector3 posicaoTropa = mainCamera.WorldToScreenPoint(tropa.transform.position);
            Vector2 posicaoTropaConvertida = new Vector2(posicaoTropa.x, Screen.height - posicaoTropa.y); //eixo Y é invertido na funcao OnGUI ou seja em Vectors 2

            if (selecao.Contains(posicaoTropaConvertida)){
                tropasSelecionadas.Add(tropa);
            }

        }

        return tropasSelecionadas.ToArray();
    }


    private void OnGUI(){

        if (Input.GetButtonDown("Fire1")) //Quando clicar pela primeira Vez
        {
            //pega a posição (X,Y) do click do mouse
            CaixaSelecaoInicialMouse = new Vector2(Input.mousePosition.x, Screen.height-Input.mousePosition.y); //dividimos pela largura da tela, pois o eixo Y é invertido na funcao OnGUI

        }


        if (Input.GetButton("Fire1")){
            //Enquanto o mouse estiver "clickado"
            CaixaSelecaoFinalMouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            GUI.DrawTexture(new Rect(CaixaSelecaoInicialMouse.x, CaixaSelecaoInicialMouse.y, CaixaSelecaoFinalMouse.x - CaixaSelecaoInicialMouse.x, CaixaSelecaoFinalMouse.y - CaixaSelecaoInicialMouse.y), selecaoTextura);
        }

        if (Input.GetButtonUp("Fire1")){
            foreach (MTropa tropaSelecionada in tropasSelecionadas)
            {
                tropaSelecionada.setSelecionada(false);


            }



            float xMinimo = Mathf.Min(CaixaSelecaoInicialMouse.x, CaixaSelecaoFinalMouse.x);  //retorna o menor X do retangulo de seleção, isto resolve o bug de o retangulo ter uma posição negativa
            float yMinimo = Mathf.Min(CaixaSelecaoInicialMouse.y, CaixaSelecaoFinalMouse.y);   //retorna o menor Y do retangulo de seleção, isto resolve o bug de o retangulo ter uma posição negativa
            float larguraSelecaoCorrigida = Mathf.Abs(CaixaSelecaoInicialMouse.x - CaixaSelecaoFinalMouse.x);
            float alturaSelecaoCorrigida = Mathf.Abs(CaixaSelecaoInicialMouse.y - CaixaSelecaoFinalMouse.y);

            tropasSelecionadas = GetTropasSelecionadas(new Rect(xMinimo, yMinimo, larguraSelecaoCorrigida, alturaSelecaoCorrigida));


            foreach(MTropa tropaSelecionada in tropasSelecionadas){

                tropaSelecionada.setSelecionada(true);

            }

        }


    }
}
