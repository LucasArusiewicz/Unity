using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTropa : MonoBehaviour {


    public Projector projetorDeSelecao;
    private bool selecionada;




    private void Start(){
        CTropa.adicionaTropa(this);
    }





    public bool getSelecionada(){
       return selecionada;
    }


    public void setSelecionada(bool select){
        if (select){
            projetorDeSelecao.enabled = true;
        }

        else {
            projetorDeSelecao.enabled = false;
        }

        selecionada = select;
    }

}
