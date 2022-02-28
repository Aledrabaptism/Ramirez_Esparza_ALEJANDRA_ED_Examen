using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de cambiar un personaje y un dialogo.
public class Inventory : MonoBehaviour
{

    private bool inventoryEnabled;

    public GameObject inventory;

    private int allSlots;

    private int enabledSlots;

    //el array es mejor manera de guardar los item y gestionarlos más rápido de manera pública.
    private GameObject[] slot;

    public GameObject slotHolder;

    // Start is called before the first frame update
    void Start()
    {
        //establecere los elementos de slots
        allSlots = slotHolder.transform.childCount;

        //aquí lo cerramos con 12 slots o cajas de inventario.
        slot = new GameObject[allSlots];

        //nuestro array debe empezar desde el indice cero 0
        for (int i = 0; i < allSlots; i++) 
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item ==null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Está tecla abrira nuestro inventario
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            inventoryEnabled = !inventoryEnabled;
        
        }
        // no es necesario poner == ya que tenemos un boleano
        if (inventoryEnabled == true) 
        {
            inventory.SetActive(true);
        
        }
        else 
        {
            inventory.SetActive(false);
        
        }
    }
    // en está parte en la información que consegui decia que ONTRIGGERENTER también servia para 2D pero creo que eso fallo al momento de correr el juego. NO FUNCIONO
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item") 
        {
            //creamos un objeto y a queremos decirle que queremos añadir un item
            GameObject itemPickedUp = other.gameObject;

            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp,item.ID,item.type,item.descripcion,item.icon);
            


        
        }
    }
    // COMO NO ESTABA ADD ITEM LO AÑADO
    public void AddItem(GameObject itemObject, int itemID,string itemType,string itemDescription, Sprite itemIcon) 
    {
        for (int i = 0; i < allSlots; i++) 
        {
            if (slot[i].GetComponent<Slot>().empty) 
            {
                itemObject.GetComponent<Item>().pickedUp = true;
                //tengo que pasar la infromación a nuestro slot

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().description = itemDescription;
                slot[i].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);


                slot[i].GetComponent<Slot>().UpdateSlot();


                slot[i].GetComponent<Slot>().empty = false;
            }
            // nuestro margen de error hasta ahora es que no había un tope,ahora se investiga el metodo de poner un return.
            return;
        }
    
    }


}
