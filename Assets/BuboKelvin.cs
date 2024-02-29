using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuboKelvin : MonoBehaviour
{
    private Transform transformacion;
    // Start is called before the first frame update
    void Start()
    {
        transformacion = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogFormat("La transformascion del objeto es: ", transformacion.localPosition(x))
    }
}
