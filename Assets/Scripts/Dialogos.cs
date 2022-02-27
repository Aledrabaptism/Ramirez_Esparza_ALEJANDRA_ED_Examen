using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de poder cambiar los dialogos.

public class Dialogos : MonoBehaviour
{
    //será mi dato que agregara valor.
    public string[] dialogos;

    public GameObject[] players;

    //representara un nuevo espacio abierto en texto
    public Text dialogoText;

    public int indice = 0;



    // Start is called before the first frame update
    void Start()
    {
        // vamos hacer un valor entero
        dialogoText.text = dialogos[indice];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            indice++;

        }
        if (indice >= dialogos.Length)
            indice = dialogos.Length - 1;


        dialogoText.text = dialogos[indice];

        switch (indice) 
        {
            case 0:
                players[0].SetActive(true);
                players[1].SetActive(false);
                players[2].SetActive(false);
                break;

            case 1:
                players[1].SetActive(true);
                players[0].SetActive(false);
                players[2].SetActive(true);
                break;
        
        }
    }
}
