using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textoPuntuacion;
    public int puntuacionGlobal = 0;
    public GameObject bridge;
    public NavMeshSurface navMesh;
    public string sceneName;
    private void Start()
    {
        Debug.Log("Dejamos el puente inactivo");
        bridge.SetActive(false);
    }
    private void Update()
    {
        textoPuntuacion.text = "Puntuacion: " + puntuacionGlobal.ToString();
        if(puntuacionGlobal == 6 )
        {
               bridge.SetActive(true);
               navMesh.BuildNavMesh();
        }if(puntuacionGlobal == 12) //puntuacion total bolas
        {
            SceneManager.LoadScene(sceneName);//carga escena win //no funciona
        }
    }

    public void SumarPuntuacion(int puntuacionASumar)
    {
        puntuacionGlobal += puntuacionASumar;
    }
}
