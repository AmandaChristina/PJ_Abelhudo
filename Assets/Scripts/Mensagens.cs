using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Mensagens : MonoBehaviour
{
    public TMPro.TextMeshProUGUI nomeObjeto;
    public TMPro.TextMeshProUGUI mensagemObjeto;
    public string nomeContato;
    // true == computador e false == celular
    public bool tipo = false;
    public bool mensagemLida = false;
    public string mensagemContato;
    bool teste;


    void update()
    {

    }
    public void AtribuiMensagens(int id)
    {
        if (id == 0)
        {
            nomeContato = "Di Gafanhoto";
            tipo = true;
            mensagemContato = "Ow meu amigo, tudo bom?" +
                "preciso da tua ajuda, o vereador cancelou o sarau dos grílo. eu tentei entrar em" +
                "contato com ele mas não fui atendido! você poderia investigar pra onde foi o dinheiro?";
            nomeObjeto.text = nomeContato;
            mensagemObjeto.text = mensagemContato;
            mensagemLida = true;
            GameStateController.controlaMensagens(id);
        }
        else if (id == 1)
        {
            nomeContato = "Prefeito Udorico Besouro";
            tipo = true;
            mensagemContato = "Ow meu amigo, tudo bom?" +
                "você me sacaneou, será crobado" +
                "contato com ele mas não fui atendido! você poderia investigar pra onde foi o dinheiro?";
            nomeObjeto.text = nomeContato;
            mensagemObjeto.text = mensagemContato;
            mensagemLida = true;
            GameStateController.controlaMensagens(id);
        }
        else if (id == 2)
        {
            nomeContato = "Besourissimo";
            tipo = true;
            mensagemContato = "valeu colega";
            nomeObjeto.text = nomeContato;
            mensagemObjeto.text = mensagemContato;
            mensagemLida = true;
            GameStateController.controlaMensagens(id);
        }
    }
}