using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int año;
    public string orientacion;
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error, el nombre no puede ser vacio");
            return;
        }

        if (año != 1 & año != 2 & año != 3 & año != 4 & año != 5)
        {
            Debug.Log("Error, no es valido el año");
            return;
        }

        else if (año < 3 & año >= 1)
        {
            Debug.Log("Error, seguis en siclo basico");
            return;
        }

        if (orientacion != "T" & orientacion != "D" & orientacion != "G" & orientacion != "M" & orientacion != "H")
        {
            Debug.Log("Error, solo se puede ingresar T, D, G, M o H");
            return;
        }

        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
