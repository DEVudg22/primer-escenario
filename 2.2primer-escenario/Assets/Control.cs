using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour

{
    float speed = 5f;

   
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 Direccion = new Vector3(horizontalInput,0, verticalInput);
        Direccion.Normalize();

        transform.position = transform.position + Direccion * speed * Time.deltaTime;
    }
}
