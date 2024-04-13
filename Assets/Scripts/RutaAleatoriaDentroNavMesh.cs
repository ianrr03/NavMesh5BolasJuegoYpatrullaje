using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RutaAleatoriaDentroNavMesh : MonoBehaviour
{
    private Vector3 destino;

    private NavMeshAgent _navMeshAgent;

    //Límites del plano inicial
    private int limiteEnX = 6;
    private int limiteEnZ = 6;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();

        //De salida asigna un destino aleatoria dentro de los limites del plano inicial
        destino = PrimerDestinoAleatorio();
        _navMeshAgent.SetDestination(destino);
    }

    // Update is called once per frame
    void Update()
    {
        rutaAleatoriaDentroNavMesh();
    }

    private void rutaAleatoriaDentroNavMesh()
    {
        //Cuando llegue cerca de su destino actual
        if (Vector3.Distance(transform.position, destino) < 2.5f)
        {
            //Obtiene un punto aleatorio alrededor
            Vector3 puntoAleatorio = Random.insideUnitSphere * 50;

            NavMeshHit hit;
            NavMesh.SamplePosition(puntoAleatorio, out hit, 50, 1);
            destino = hit.position;
            _navMeshAgent.SetDestination(destino);
        }
        else
        {
            if (_navMeshAgent.velocity.x <= 0 && _navMeshAgent.velocity.z <= 0)
            {
                _navMeshAgent.SetDestination(destino);
            }
        }
    }

    private Vector3 PrimerDestinoAleatorio()
    {
        return new Vector3(Random.Range(-limiteEnX, limiteEnX), transform.position.y, Random.Range(-limiteEnZ, limiteEnZ));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { //Recarga la escena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
