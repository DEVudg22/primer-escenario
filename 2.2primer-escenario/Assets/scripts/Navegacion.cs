using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//SCRIPT PARA NAVEGAR ENTRE LAS ESCENAS

public class Navegacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena (string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

}
