using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdUsuario : MonoBehaviour
{   
    public int id;
    private GameObject managerUsuarios;
    public GameObject lista;

    public void clickUsuario()
    {
        managerUsuarios = GameObject.FindWithTag("MUsu");
        if (lista.GetComponent<Lista>().borrar)
        {
            lista.GetComponent<Lista>().borrarUsuario(id);
            managerUsuarios.GetComponent<ManagerUsuario>().guardarUsuarios();
        }
        else
        {
            Debug.Log(id);
        }
    }
    public void clickUsuarioEjercicios()
    {
        GameObject ejercicios = GameObject.FindWithTag("Ejercicios");
        ejercicios.GetComponent<Ejercicios>().id = id;
        ejercicios.GetComponent<Ejercicios>().ActivarPanel();

    }
   
}
