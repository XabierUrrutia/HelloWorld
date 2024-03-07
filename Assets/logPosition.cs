using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logPosition : MonoBehaviour
{
    private int velocidad = 1;
    private float posX = 0, posY = 1, posZ = 0, escX = 2, escY = 2, escZ = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
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
            posZ = transform.position.z + velocidad;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            posZ = transform.position.z - velocidad;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            posX = transform.position.x - velocidad;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            posX = transform.position.x + velocidad;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            escY = transform.localScale.y + velocidad;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            escX = transform.localScale.x + velocidad;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            escZ = transform.localScale.z + velocidad;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            escY = transform.localScale.y - velocidad;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            escX = transform.localScale.x - velocidad;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            escZ = transform.localScale.z - velocidad;
        }

        this.transform.position = new Vector3(posX, posY, posZ);
        this.transform.localScale = new Vector3(escX, escY, escZ);
    }
}
