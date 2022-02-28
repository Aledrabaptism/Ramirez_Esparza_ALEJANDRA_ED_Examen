using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: Investigue un metodo para poner el texto a los slots
// derechos de autor: https://www.youtube.com/watch?v=7uyowDMC1j4&list=RDCMUC_XaEmy0Rz49GkrhtpzqWlw&index=2&ab_channel=LuisCanary
public class Slot : MonoBehaviour
{
    public GameObject item;

    public int ID;

    public string type;

    public string description;

    public bool empty;

    public Sprite icon;

    public Transform slotIconGameObject;

    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
    }
    // se crea un metodo para que los item no salcan con opacidad minima,
    public void UpdateSlot() 
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    
    }

    public void UseItem() 
    {
    
    }
    
}
