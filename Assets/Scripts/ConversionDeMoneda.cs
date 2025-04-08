using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;
    void Start()
    {
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.35f;
        }

        else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        }

        else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;
        }

        else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }

        montoConvertido = montoAConvertir / cotizacionMoneda;

        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
