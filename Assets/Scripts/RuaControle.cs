using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuaControle : MonoBehaviour 
{
    public GameStateController gsc;
    public GameObject borboleta;
    public PlayerControl player;

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
        if (npcInteragidos[0])
        {
            AtivaBorboleta();
        }
        else if (npcInteragidos[2]) {
            player.dinheiro = player.dinheiro - 200;
            gsc.progresso[0] = true;
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

