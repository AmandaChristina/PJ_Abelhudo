using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecao : MonoBehaviour
{
    Camera cam;
    public GameObject balao;


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Input.GetMouseButtonDown(0)){

            if(Physics.Raycast(ray, out hit)){
                Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);
                
                if(hit.transform.gameObject.name == "pudim"){
                    balao.SetActive(true);
                }

                else{              
                    balao.SetActive(false);

                }
            }

        }
        
    }
}
