using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 3f;
    private Rigidbody rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }//start

    // Update is called once per frame
    void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH * velocidad, 0.0f, movimientoV * velocidad);

        rb.AddForce(movimiento);
    }//update
}//main
