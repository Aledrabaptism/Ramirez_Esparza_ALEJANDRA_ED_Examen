using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: Habilitaremos los botones o sincronizaremos las escenas de juego.
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // crearemos el primer enlace para la primer escena, que se llama NARUTO pero lo cambie a juego
    public void EscenaJuego() 
    {
        SceneManager.LoadScene("Juego");
    
    }
    // en está parte vamos hacer un enlace para que los demás botones cambien a su propia escena.
    public void CargarNivel(string nombreNivel) 
    {
        SceneManager.LoadScene(nombreNivel);

    
    }
}
