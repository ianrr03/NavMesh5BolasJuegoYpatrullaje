using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(this.gameObject); //Para que destruya la bola si la toca el player

        }
            

    }//OnCollisionEnter
}//main
