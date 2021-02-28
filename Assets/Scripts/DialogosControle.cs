using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogosControle : MonoBehaviour
{
    private List<string> frases = new List<string>();
    private List<string> respostas = new List<string>();
    public Text textoUI;
    public TMPro.TextMeshProUGUI respostasUI;
    public GameObject balao;
    public PersonagemInteragivel npc;
    public BoxCollider boxCollider;

    public void ComecaDialogo(Dialogos dialogo) {
        Debug.Log("Começa conversa com " + dialogo.nome);
        balao.SetActive(true);
        frases.Clear();
        respostas.Clear();
            foreach (string frase in dialogo.frases)
            {
                frases.Add(frase);
            }
            foreach (string resposta in dialogo.respostas)
            {
                respostas.Add(resposta);
            }
        if (frases.Count != 0)
        {
            frases.Remove(dialogo.frases[dialogo.frases.Length - 1]);
            respostas.Remove(dialogo.respostas[dialogo.respostas.Length - 1]);
        }
        if (npc.interagiu)
        {
            if (dialogo.frases.Length != 0)
            {
                frases.Clear();
                respostas.Clear();
                frases.Add(dialogo.frases[dialogo.frases.Length - 1]);
                respostas.Add(dialogo.respostas[dialogo.respostas.Length - 1]);
            }

        }
        boxCollider.enabled = false;
        DisplayNextSetence();       
    }

    public void DisplayNextSetence() {

        if (frases.Count == 0) {
            FimDialogo();
            return;
        }

        string frase = frases[0];
        frases.RemoveAt(0);
        Debug.Log(frase);
        textoUI.text = frase;

        string resposta = respostas[0];
        respostas.RemoveAt(0);
        respostasUI.text = resposta;
     
       
    }

    public void FimDialogo() {
        Debug.Log("Cabo");
        balao.SetActive(false);
        npc.interagiu = true;
        RuaControle.salvaDialogo(npc.id);
        boxCollider.enabled = true;
    }

      void Start()
    {
        frases = new List<string>();
        respostas = new List<string>();
        
    }
    void Update() {
        
    }

}
