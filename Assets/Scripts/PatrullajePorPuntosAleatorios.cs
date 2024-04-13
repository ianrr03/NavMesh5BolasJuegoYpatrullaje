using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PatrullajePorPuntosAleatorios : MonoBehaviour
{
    public Transform rutaPadre;
    int indiceHijos;
    Vector3 destino;
    void Start()
    {
        //destino = rutaPadre.GetChild(indiceHijos).position; //para patrullaje por puntos y aleatorio
        //destino = destinoAleatorio(); //para patrullaje por ruta aleatoria delimitada
        GetComponent<NavMeshAgent>().SetDestination(destino);
    }

    // Update is called once per frame
    void Update()
    {
        #region patrullaje por puntos aleatorios
        if (Vector3.Distance(transform.position, destino) < 2.5f)
        {
            indiceHijos = Random.Range(0, rutaPadre.childCount);
            indiceHijos++;
            if (indiceHijos >= rutaPadre.childCount)
                indiceHijos = 0; //Comenzamos otra vez en el punto primero
            destino = rutaPadre.GetChild(indiceHijos).position;
            GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(destino);
        }//if

        #endregion
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Carga otra vez la escena

    }//OnCollisionEnter
}
