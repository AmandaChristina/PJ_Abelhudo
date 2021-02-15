using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
 
    static public double dinheiro = 1000;
    static public int habilidade;
    static public int habilidade2;
    static public int sensacionalista;
    static public int imparcialista;

    public float speed;
    static public int dificuldade;
    static public int contSucesso;
    static public int contFracasso;
    static public bool testResultado;

    static public int dado;
    static public int somaTeste;



    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 pos = new Vector3(xMove, yMove, 0);
        transform.position += pos;

        if(Input.GetKeyDown(KeyCode.F)){
            dinheiro -= 20 * dificuldade;
            print(dinheiro);
        }
        else if(Input.GetKeyDown(KeyCode.G)){
            sensacionalista++;
            habilidadeTest(dificuldade, habilidade);
            
        }
        else if(Input.GetKeyDown(KeyCode.V)){
            imparcialista++;
            habilidadeTest(dificuldade, habilidade2);
        }
    }


     static public bool habilidadeTest(int dif, int hab){

        dado = Random.Range(1,21);
        somaTeste = dado+hab;

        if(somaTeste >= dif*5){
                //print("sucesso");
                contSucesso++;
                return testResultado  = true;
        }

        else{
            dificuldade+=1;
            //print("fracasso");
            contFracasso++;
            return testResultado = false;
        }
    }
}




    