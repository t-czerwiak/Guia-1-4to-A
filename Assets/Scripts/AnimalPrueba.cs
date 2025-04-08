using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPrueba : MonoBehaviour
{

public string codigoAnimal;
public int cantidadDias;
int totalGramos;
float costoAlimento;

void Start()
    {
		if (cantidadDias <= 3)
		{
			Debug.Log("error, la cantidad de dias tiene que ser mayor que 3");
			return;
		}

		if (codigoAnimal == "G")
		{
			totalGramos = cantidadDias * 300;
			costoAlimento = totalGramos / 100 * 80;
			Debug.Log("Para este periodo se necesitan " + totalGramos + "gramos de alimento. ");
			Debug.Log("Costo de esa cantidad de alimento: $" + costoAlimento);
		}

		else if (codigoAnimal == "PP")
		{
			totalGramos = cantidadDias * 400;
			costoAlimento = totalGramos / 100 * 80;
			Debug.Log("Para este periodo se necesitan " + totalGramos + "gramos de alimento. ");
			Debug.Log("Costo de esa cantidad de alimento: $" + costoAlimento);
		}

		else if (codigoAnimal == "PG")
		{
			totalGramos = cantidadDias * 700;
			costoAlimento = totalGramos / 100 * 80;
			Debug.Log("Para este periodo se necesitan " + totalGramos + "gramos de alimento. ");
			Debug.Log("Costo de esa cantidad de alimento: $" + costoAlimento);
		}

		else if (codigoAnimal != "G" && codigoAnimal != "PP" && codigoAnimal != "PG")
		{
			Debug.Log("error, codigoAnimal solo puede valer G por gato, PP por perro pequeño, o PG por perro grande");
			return;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
