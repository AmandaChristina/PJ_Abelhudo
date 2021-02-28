using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemInteragivel : MonoBehaviour
{
    public int id;
    public bool interagiu = false;
    public Dialogos dialogo;

    public void TriggerDialogo() {
        FindObjectOfType<DialogosControle>().ComecaDialogo(dialogo);
    } 
}
