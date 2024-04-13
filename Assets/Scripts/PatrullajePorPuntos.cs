using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PatrullajePorPuntos : MonoBehaviour
{
    public Transform rutaPadre;
    int indiceHijos;
    Vector3 destino;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region patrullaje por puntos
        if (Vector3.Distance(transform.position, destino) < 2.5f)

            indiceHijos++;
        if (indiceHijos >= rutaPadre.childCount)
        {
            indiceHijos = 0; //Comenzamos otra vez en el punto primero
        }
        destino = rutaPadre.GetChild(indiceHijos).position;
        GetComponent<NavMeshAgent>().SetDestination(destino);
        #endregion
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Carga otra vez la escena

    }//OnCollisionEnter

}
