using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int valor1 = 30;
    int valor2 = 20;

    // Start is called before the first frame update
    void Start()
    {
        //<,>, ==, <=, >=
        //&& -> AND -> true && true -> true / false && true -> false
        //|| -> Or -> true || true -> true / false || true -> true / false || flase -> false
        //!= -> Diferent 
        
        switch (valor1)
        {
            case 0:
                print("El valor de 1 es 0");
                break;
            case 1:
            case 2:
            case 3:
            case 4:
                print("El valor 1 es mayor que 0");
                break;
        }

        //if (valor1 > valor2 && valor1 < 30)
        //{
        //    print("El valor 1 que es " + valor1 + ", es mayor");
        //}
        //else if (valor1>30)
        //{
        //    print("Valor 1 es un número muy grande");
        //}
        //else if (valor1 != 50)
        //{
        //    print("El valor es distinto de 50");
        //}
        //else
        //{
        //    print("El valor 1 es 30");
        //}

        //else if (valor1 == valor2)
        //{
        //    print("Los valores son iguales!");
        //}
        //else
        //{
        //    print("El valor 2 que es " + valor2 + ", es mayor");
        //}
        //switch ()
        //{

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
