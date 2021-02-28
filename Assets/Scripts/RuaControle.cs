using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuaControle : MonoBehaviour 
{
    public GameStateController gsc;
    public GameObject borboleta;


    public static bool[] npcInteragidos = new bool[5];
    // Start is called before the first frame update
    public void AtivaBorboleta() {
            
            borboleta.SetActive(true);
            
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (npcInteragidos[0]) {
            AtivaBorboleta();
        }
    }
    public static void salvaDialogo(int id)
    {
        for (int i = 0; i < npcInteragidos.Length; i++)
        {
            if (i == id)
            {
                npcInteragidos[id] = true;
                Debug.Log("Interagiu com personagem id = " + id);
            }
        }
    }
  
}

