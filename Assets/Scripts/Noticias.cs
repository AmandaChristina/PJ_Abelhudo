using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noticias : MonoBehaviour
{
    public GameObject pj;
    PlayerControl pjScript;
    GerenciaConversa gerenciaScript;

    static public int habilidadeEscrita;
    static public int habilidadeEscrita2;
    public int dificuldadeNoticia;

    void Start(){

    }

    void Update(){
        print (PlayerControl.dinheiro);
    }

    public void noticiaFakeNews(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, 0);
    }

    public void noticiaSensacionalista(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita2);
    }

    public void noticiaImparcial(){
        PlayerControl.habilidadeTest(dificuldadeNoticia, habilidadeEscrita);
    } 
}
