using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    
    private float tiempoRestante = 60f;

    void Start()
    {
        // Comienza la coroutine para el temporizador
        StartCoroutine(ContadorDeTiempo());
    }

    IEnumerator ContadorDeTiempo()
    {
        while (tiempoRestante > 0f)
        {
            // Disminuye el tiempo restante
            tiempoRestante -= Time.deltaTime;

            // Actualiza visualmente el temporizador (aquí puedes mostrarlo en un UI)
            Debug.Log("Tiempo restante: " + tiempoRestante.ToString("F0") + " segundos");

            // Espera un frame antes de continuar
            yield return null;
        }

        // El temporizador ha llegado a cero
        Debug.Log("¡Tiempo terminado!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Carga otra vez la escena

    }
}
