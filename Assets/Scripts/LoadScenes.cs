using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadEscritorio()
    {
        Debug.Log("LoadEscritório");
        SceneManager.LoadScene("Escritorio");
    }
    public void LoadPt1()
    {
        Debug.Log("LoadPt1");
        SceneManager.LoadScene("Pj1");
    }
}
