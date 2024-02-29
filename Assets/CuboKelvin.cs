using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboKelvin : MonoBehaviour
{
    private GameObject otherObject;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        otherObject = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.LogFormat("La transformascion del objeto es: " + otherObject.transfom.position);
    }
}
