using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Carga otra vez la escena
        
    }//OnCollisionEnter
}//main
