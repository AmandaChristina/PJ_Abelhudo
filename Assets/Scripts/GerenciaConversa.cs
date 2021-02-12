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
    public bool sucessoNoticias;
     
     void Update(){
        if(dialogoDados != null ){

            if(pj.testResultado == true){
                textoUI.text = dialogoDados.frasesSucesso[pj.contSucesso] + " (" + pj.testResultado +")";
            }

            else if(pj.testResultado == false){
                textoUI.text = dialogoDados.frasesFracasso[pj.contFracasso] + " (" + pj.testResultado +")";
            }
            finalMissao();
        }        
    }

    void finalMissao(){
//gerenciaScript.pj.contSucesso > gerenciaScript.pj.contFracasso && gerenciaScript.pj.contSucesso >= 2 && 
        if(dialogoDados.sucessoMissao == true && pj.contSucesso > pj.contFracasso && pj.contSucesso >=2){ 
                print("Missao Sucesso");
                sucessoNoticias = true;
            }
}
}