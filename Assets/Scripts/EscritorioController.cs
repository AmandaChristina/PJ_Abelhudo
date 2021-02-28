using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscritorioController : MonoBehaviour
{
    public GameObject ruaButtom;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStateController.mensagemLidaController[0])
        {
            ruaButtom.SetActive(true);
        }
    }
}
