using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de almacenar
public class DialogoBluePrint : MonoBehaviour
{
    //que numero de personaje se vera en pantalla
    public int numeroDialogo;

    //bloques de informacion de character donde hicimos un c# character
    public Character character;

    [TextArea(3,10)]
    public string[] dialogo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
