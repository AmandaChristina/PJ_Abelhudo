using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Noticias : MonoBehaviour
{
    GerenciaConversa gerenciaScript;
    public GameObject painelNoticias;
    static public int habilidadeEscrita;
    static public int habilidadeEscrita2;
    public int dificuldadeNoticia;
    bool noticiaConcluida;
    bool testResultadoNoticia;

    public Text repercussaoResultado;
    public Text dinheiroResultado;
    public Text pontoHabilidadeResultado;



    void Start(){

    }

    void Update(){
        print (PlayerControl.dinheiro);

        if(noticiaConcluida) painelNoticias.SetActive(false);

        resultadosManager();

    }

    public void noticiaFakeNews(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, 0);
        testResultadoNoticia = PlayerControl.testResultado;
        noticiaConcluida  = true;
        print(PlayerControl.testResultado);
    }

    public void noticiaSensacionalista(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita2);
        noticiaConcluida  = true;
        testResultadoNoticia = PlayerControl.testResultado;        
        print(PlayerControl.testResultado);
    }

    public void noticiaImparcial(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita);
        testResultadoNoticia = PlayerControl.testResultado;
        noticiaConcluida  = true;
        print(PlayerControl.testResultado);
    }

    void textoResultManager(){
            repercussaoResultado.text = PlayerControl.repercussao.ToString();
            dinheiroResultado.text = PlayerControl.dinheiro.ToString();
            pontoHabilidadeResultado.text = PlayerControl.pontoDeHabilidade.ToString();
    }

    void resultadosManager(){
        if(testResultadoNoticia){
            PlayerControl.repercussao += 35;
            PlayerControl.dinheiro+= 500;
            PlayerControl.pontoDeHabilidade +=1;
        }
        else{

            PlayerControl.repercussao -= 10;
        }
                    textoResultManager();

    }
}
