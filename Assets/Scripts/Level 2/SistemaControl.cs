using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Nombre completo:Alejandra Pamela Ramírez Esparza
//Asignatura: Estructura de datos
//Nombre y número del ejercicio: completar visual novel Ejercicio 1
//Descripción de los que hace el script: tendrá la función de cambiar un personaje y un dialogo.
public class SistemaControl : MonoBehaviour
{
    //agregaremos sistemas publicos para aparecerlos en la interfaz
    public Text dialogoTexto;

    public Text nombreActor;

    public Image imagenActor;

    public List<DialogoBluePrint> dialogoList;

    public int indiceDialogo;

    public int ActorActual; // el actor actual no ayudara a posicionar al actor, antes de avanzar al otro.

    // Start is called before the first frame update
    void Start()
    {
        SiguienteDialogo(dialogoList[ActorActual],indiceDialogo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            indiceDialogo++;

            if (indiceDialogo >= dialogoList[ActorActual].dialogo.Length)
            {
                indiceDialogo = dialogoList[ActorActual].dialogo.Length - 1;
                ActorActual++; // en este apartado cambiaremos de actor.
                if(ActorActual >= dialogoList.Count)
                {
                    ActorActual = dialogoList.Count - 1;

                }

                indiceDialogo = 0;
            }






            



        
        }

        SiguienteDialogo(dialogoList[ActorActual], indiceDialogo);


    }




    public void SiguienteDialogo(DialogoBluePrint dialogoActual,int indiceDialogo) {

        //generamos e indicamos que image va aparecer
        nombreActor.text = dialogoActual.character.nombreCharacter;
        dialogoTexto.text = dialogoActual.dialogo[indiceDialogo];
        imagenActor.sprite = dialogoActual.character.imagenCharacter;

    }












}
