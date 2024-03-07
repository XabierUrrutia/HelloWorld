using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logPosition : MonoBehaviour
{
    public float velocidad = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        checkRotation();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
           //Debug.Log("Espacio pulsado");
           Debug.Log("Position of X " + this.transform.position.x);
           Debug.Log("Position of Y " + this.transform.position.y);
           Debug.Log("Position of Z " + this.transform.position.z);
        } 
    }

    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //posZ = transform.position.z + velocidad;
            transform.position += Vector3.up*velocidad;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //posZ = transform.position.z - velocidad;
            transform.position += Vector3.down * velocidad;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //posX = transform.position.x - velocidad;
            transform.position += Vector3.left * velocidad;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //posX = transform.position.x + velocidad;
            transform.position += Vector3.right * velocidad;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.down;
        }

      
 
       
    }
    private void checkRotation()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1, 0);
    }
}
