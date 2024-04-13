using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int bolaDestruida = 0;
    public GameObject bridge;
    public NavMeshSurface navMesh;
    //public string tipoDeObjeto = "Bola"; // Cambia "TipoDeObjeto" al nombre del componente que estás buscando
    //private int cantidadDeObjetos = 0;
    private void Start()
    {

        Debug.Log("Dejamos el puente inactivo");
        bridge.SetActive(false);
        //GameObject[] objetosEncontrados = GameObject.FindGameObjectsWithTag("Bola");
        //cantidadDeObjetos = objetosEncontrados.Length;
        //Debug.Log("Cantidad de objetos de tipo " + tipoDeObjeto + ": " + cantidadDeObjetos);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        
        //Para que destruya la bola si la toca el player
        //    bolaDestruida++;
        //}if (bolaDestruida <= 0)
        //{
        //    bridge.SetActive(true);
        //    navMesh.BuildNavMesh();
        }


    }//OnCollisionEnter
}//main
