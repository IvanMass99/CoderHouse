using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // Varialbes

    public float velocidad = 3f;
    public float rotacion = 200f;
 

    // Metodos

  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * velocidad * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -rotacion * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, rotacion * Time.deltaTime);
        
    }
}
