using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparatives_If_Else : MonoBehaviour
{
    public int valor1;
    public int valor2;

    public bool condition;

    // Start is called before the first frame update
    void Start()
    {
        //Pueden usar los signos de comparación que conocen tales como:
        /*
        < es Menor
        > es Mayor
        == es Igual
        <= es Menor Igual
        >= es Mayor Igual
        */

        //Paso 1 - Comparación Simple
        //if (valor1 > valor2)
        //    print("Valor 1 es mayor que Valor 2");
        //else
        //    print("Valor 2 es mayor que Valor 1");

        //Paso 2 - Comparación usando else if
        //if (valor1 > valor2)
        //    print("Valor 1 es MAYOR que Valor 2");
        //else if (valor1 == valor2)
        //    print("Valor 1 es IGUAL que Valor 2");
        //else
        //    print("Valor 1 es MENOR que Valor 2");

        //Paso 3 - Usando bools
        //if (condition == true)
        //    print("La condición es cierta");
        //else
        //    print("La condición no es cierta");

        //Otros signos para condicionales
        /*
        || -> Or. Ejm: Siempre va a ser true, a excepción de si:
        1) false || false -> false
        Para todo el resto:
        2) true || false -> true
        3) false || true -> true
        4) true || true -> true

        && -> And. Ejm: Siempre va a ser false, a excepción de si:
        1) true && true -> true
        2) true && false -> false
        3) false && true -> false
        4) false && false -> false

        != -> Not.
        -> !false -> true
        -> !true -> false
        */

        //if(condition == false) == if(!condition)
        //if(condition==true) == if(condition)

        //Paso 4 - If anidado

        if (condition)
        {
            if (valor1 > valor2)
                print("Valor 1 es MAYOR que Valor 2 y la condición es VERDADERA");
            else if (valor1 == valor2)
                print("Valor 1 es IGUAL que Valor 2 y la condición es VERDADERA");
            else
                print("Valor 1 es MENOR que Valor 2 y la condición es VERDADERA");
        }
        else
        {
            if (valor1 > valor2)
                print("Valor 1 es MAYOR que Valor 2 y la condición es FALSA");
            else if (valor1 == valor2)
                print("Valor 1 es IGUAL que Valor 2 y la condición es FALSA");
            else
                print("Valor 1 es MENOR que Valor 2 y la condición es FALSA");
        }

    }

    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //    print("Personaje se mueve a la derecha");
        //else if (Input.GetKeyDown(KeyCode.A))
        //    print("Personaje se mueve a la izquierda");
        //else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        //    print("Personaje No se mueve");

    }
}
