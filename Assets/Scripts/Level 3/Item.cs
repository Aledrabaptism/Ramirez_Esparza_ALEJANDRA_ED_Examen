using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre completo:Alejandra Pamela Ram�rez Esparza
//Asignatura: Estructura de datos
//Nombre y n�mero del ejercicio: completar visual novel Ejercicio 1
//Descripci�n de los que hace el script: tendr� la funci�n de cambiar un personaje y un dialogo.
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
    // en est� parte es donde no recuerdo como poner el botton para que salga el texto, ya que en la clase s�lo estaba ligada a un cambio de personaje.
    public void ItemUsage()
    {
        if(type == "weapon")
        {
            equipped = true;
        }


    }



    
}
