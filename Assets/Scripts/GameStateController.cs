using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public Mensagens jp;
    public static bool[] mensagemLidaController = new bool[3];

    public static void controlaMensagens(int id){
        Debug.Log("Funsão chamada");
        for (int i = 0; i < 3; i++) {
            Debug.Log("Loop show");
            if (i == id ) {
                mensagemLidaController[i] = true;
                Debug.Log("Valor atribuido" + id + " ="+ mensagemLidaController[i]);
            }
        
        }
     
    
}
    void Start(){
        if (mensagemLidaController[0])
        {
            jp.MensagemDiGafanhoto();
            Debug.Log(mensagemLidaController[0]);
        }
      

    }

    // Update is called once per frame
    void Update(){
      
    }

}
