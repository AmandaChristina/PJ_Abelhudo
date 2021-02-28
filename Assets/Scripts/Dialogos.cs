using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogos
{
    public string nome;
    [TextArea(3, 10)]
    public string[] frases;
    [TextArea(3,10)]
    public string[] respostas;
    //[TextArea(3, 10)]
    //public string[] frasesFracasso;
    //[TextArea(3, 10)]
    //public string[] respostasPersonagem;
}
