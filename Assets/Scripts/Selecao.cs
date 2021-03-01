using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecao : MonoBehaviour
{   
    Camera cam;
    public DialogosControle controle;
    //GerenciaConversa gerenciaScript;
    public GameObject balao;
    public PersonagemInteragivel interage;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        //gerenciaScript = GetComponent<GerenciaConversa>();
    
      
    }

    // Update is called once per frame
    void Update()
    {
        #region Raycast
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0)){

            if(Physics.Raycast(ray, out hit)){
                Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);
                
                if(hit.transform.gameObject.tag == "conversar"){
                    interage = hit.transform.GetComponent<PersonagemInteragivel>();
                    controle.npc = hit.transform.GetComponent<PersonagemInteragivel>();
                    controle.boxCollider = hit.transform.GetComponent<BoxCollider>();
                  /*gerenciaScript.dialogoDados = hit.transform.GetComponent<PersonagemInteragivel>();
                  PlayerControl.contFracasso = 0;
                  PlayerControl.contSucesso = 0;
                  PlayerControl.testResultado = true;*/

                    interage.TriggerDialogo();
                }

               /* else{              
                    balao.SetActive(false);
                }*/
            }

        }
        #endregion
        if(Input.GetKeyDown(KeyCode.X)){
            balao.SetActive(false);
            controle.boxCollider.enabled = true;

        } 


        
    }

}
