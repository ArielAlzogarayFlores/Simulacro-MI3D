using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float montoD;
    public float precio1;
    public float precio2;
    public float precio3;

    // Start is called before the first frame update
    void Start()
    {
        float sumaprecios = precio1 + precio2 + precio3;

        if (sumaprecios > montoD)
        {
            float sobra = sumaprecios - montoD;

            Debug.Log("La suma de los precios de los productos supera el monto disponible.");
            Debug.Log("Sobra un total de $" + sobra);
        
        }
        else
        {
            float falta = montoD - sumaprecios;
            Debug.Log("La suma de los precios de los productos no supera el monto disponible.");
            Debug.Log("Falta un total de $" + falta);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
