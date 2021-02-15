using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerenciaConversa : MonoBehaviour
{
    public Text textoUI;
    public PersonagemInteragivel dialogoDados;
    public PlayerControl pj;
    static public bool sucessoNoticias;
     
     void Update(){
        if(dialogoDados != null ){

            if(PlayerControl.testResultado == true){
                textoUI.text = dialogoDados.frasesSucesso[PlayerControl.contSucesso] + " (" + PlayerControl.testResultado +")";
            }

            else if(PlayerControl.testResultado == false){
                textoUI.text = dialogoDados.frasesFracasso[PlayerControl.contFracasso] + " (" + PlayerControl.testResultado +")";
            }
            finalMissao();
        }        
    }

    void finalMissao(){
            if(PlayerControl.contSucesso > PlayerControl.contFracasso && PlayerControl.contSucesso >=2) { 
                print("Missao Sucesso");
                sucessoNoticias = true;
            }
    }

    public void carregarEscritorio(){

        SceneManager.LoadScene(1);

    }

}