using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class ActivationBridge : MonoBehaviour
{
    public GameObject bridge;
    public NavMeshSurface navMesh;

   


    void Start()
    {
        Debug.Log("Dejamos el puente inactivo");
        bridge.SetActive(false);

        
    }

    
    void Update()
    {
        
    }
}
