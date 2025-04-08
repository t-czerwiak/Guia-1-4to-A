using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;
    float cotizacionDolar = 1204.35f;
    float cotizacionEuro = 1541.11f;
    float cotizacionReal = 201.24f;
    float minimoAConvertir = 1000;
    void Start()
    {
        if (montoAConvertir < minimoAConvertir)
        {
            Debug.Log("El monto minimo es de $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;
        }

        else if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro;
        }

        else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal;
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
