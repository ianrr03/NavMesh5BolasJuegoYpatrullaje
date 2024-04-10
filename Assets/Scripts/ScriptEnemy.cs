using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ScriptEnemy : MonoBehaviour
{
    
    private NavMeshAgent agent;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.position;
       
    }
    //Falta metodo de colision

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Carga otra vez la escena

    }//OnCollisionEnter
}//main
