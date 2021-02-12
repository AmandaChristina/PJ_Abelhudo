using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public double dinheiro;
    public int habilidade;
    public int habilidade2;
    public int dificuldade;
    public int contSucesso;
    public int contFracasso;
    public bool testResultado;
    public int sensacionalista;
    public int imparcialista;
    int dado;
    int somaTeste;



    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 pos = new Vector3(xMove, yMove, 0);
        transform.position += pos;

        if(Input.GetKeyDown(KeyCode.F)){

            dinheiro -= 20 * dificuldade;
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



     bool habilidadeTest(int dif, int hab){


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




    