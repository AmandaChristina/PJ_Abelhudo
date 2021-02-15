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
    public Text resultadoNoticiaText;

    public GameObject noticiaImparcialButton;
    public GameObject noticiaSensacionalistaButton;



    void Start(){

    }

    void Update(){
        print (PlayerControl.dinheiro);
        if(noticiaConcluida) painelNoticias.SetActive(false);
        noticiasLiberadas();
        

    }

    public void noticiaFakeNews(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, 0);
        testResultadoNoticia = PlayerControl.testResultado;
        print(PlayerControl.testResultado);
        resultadosManager();
        noticiaConcluida  = true;
    }
    public void noticiaSensacionalista(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita2);
        testResultadoNoticia = PlayerControl.testResultado;        
        print(PlayerControl.testResultado);
        resultadosManager();
        noticiaConcluida  = true;
    }
    public void noticiaImparcial(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita);
        testResultadoNoticia = PlayerControl.testResultado;
        print(PlayerControl.testResultado);
        resultadosManager();
        noticiaConcluida  = true;
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

            resultadoNoticiaText.text = "Sucesso!!";
        }
        else{

            PlayerControl.repercussao -= 10;
            resultadoNoticiaText.text = "Foi péssimo!!";
        }
                    textoResultManager();

    }
    public void noticiasLiberadas(){
        if(GerenciaConversa.sucessoNoticias){
            noticiaImparcialButton.SetActive(true);
            noticiaSensacionalistaButton.SetActive(true);
        }
    }
}
