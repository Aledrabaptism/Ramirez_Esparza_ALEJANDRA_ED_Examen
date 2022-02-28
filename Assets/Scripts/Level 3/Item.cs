using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de cambiar un personaje y un dialogo.
public class Item : MonoBehaviour
{
    public int ID;

    public string type;

    public string descripcion;

    public Sprite icon;

    //ocultare la variable publica

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equipped;

    private void Update()
    {
        if (equipped) 
        {
        
        }
        
    }
    // en está parte es donde no recuerdo como poner el botton para que salga el texto, ya que en la clase sólo estaba ligada a un cambio de personaje.
    public void ItemUsage()
    {
        if(type == "weapon")
        {
            equipped = true;
        }


    }



    
}
