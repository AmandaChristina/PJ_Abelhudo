using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public Mensagens jp;
    public static bool[] mensagemlidacontroller = new bool[3];

    public static void controlaMensagens(int id){
        Debug.Log("Funsão chamada");
        for (int i = 0; i < 3; i++) {
            Debug.Log("Loop show");
            if (i == id ) {
                mensagemlidacontroller[i] = true;
                Debug.Log("Valor atribuido" + id + " ="+ mensagemlidacontroller[i]);
            }
        
        }
     
    
}
    void Start(){
        if (mensagemlidacontroller[0])
        {
            jp.MensagemDiGafanhoto();
            Debug.Log(mensagemlidacontroller[0]);
        }

    }

    // Update is called once per frame
    void Update(){
      
    }

}
