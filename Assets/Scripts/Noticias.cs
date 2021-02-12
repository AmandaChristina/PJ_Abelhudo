using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noticias : MonoBehaviour
{
    public GameObject pj;
    PersonagemInteragivel pjScript;
    GerenciaConversa gerenicaScript;

    void Start(){

        pjScript = pj.GetComponent<PersonagemInteragivel>();
        gerenciaScript = pj.Find("/Main Camera");

    }
}
