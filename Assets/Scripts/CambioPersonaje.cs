using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de poder cambiar los dialogos.
public class CambioPersonaje : MonoBehaviour
{
    public GameObject player1;

    public GameObject player2;

    public GameObject player3;


    // Start is called before the first frame update
    void Start()
    {
        player1.SetActive(false);
        player2.SetActive(true);
        player3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            player1.SetActive(true);
        
        }
        if (Input.GetKey(KeyCode.Alpha4)) 
        {
            player2.SetActive(false);
        
        }
        if (Input.GetKey(KeyCode.Alpha5)) 
        {
            player3.SetActive(true);
        
        }
        if (Input.GetKey(KeyCode.Alpha5)) 
        {
            player1.SetActive(false);
        
        }
    }

}
