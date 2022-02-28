using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre completo:Alejandra Pamela Ram�rez Esparza
//Asignatura: Estructura de datos
//Nombre y n�mero del ejercicio: completar visual novel Ejercicio 1
//Descripci�n de los que hace el script: tendr� la funci�n de cambiar un personaje y un dialogo.
public class Inventory : MonoBehaviour
{

    private bool inventoryEnabled;

    public GameObject inventory;

    private int allSlots;

    private int enabledSlots;

    //el array es mejor manera de guardar los item y gestionarlos m�s r�pido de manera p�blica.
    private GameObject[] slot;

    public GameObject slotHolder;

    // Start is called before the first frame update
    void Start()
    {
        //establecere los elementos de slots
        allSlots = slotHolder.transform.childCount;

        //aqu� lo cerramos con 12 slots o cajas de inventario.
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
        //Est� tecla abrira nuestro inventario
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
    // en est� parte en la informaci�n que consegui decia que ONTRIGGERENTER tambi�n servia para 2D pero creo que eso fallo al momento de correr el juego. NO FUNCIONO
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item") 
        {
            //creamos un objeto y a queremos decirle que queremos a�adir un item
            GameObject itemPickedUp = other.gameObject;

            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp,item.ID,item.type,item.descripcion,item.icon);
            


        
        }
    }
    // COMO NO ESTABA ADD ITEM LO A�ADO
    public void AddItem(GameObject itemObject, int itemID,string itemType,string itemDescription, Sprite itemIcon) 
    {
        for (int i = 0; i < allSlots; i++) 
        {
            if (slot[i].GetComponent<Slot>().empty) 
            {
                itemObject.GetComponent<Item>().pickedUp = true;
                //tengo que pasar la infromaci�n a nuestro slot

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
            // nuestro margen de error hasta ahora es que no hab�a un tope,ahora se investiga el metodo de poner un return.
            return;
        }
    
    }


}
