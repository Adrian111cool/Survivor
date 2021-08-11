using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int valor1;
    public int valor2;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            ImprimeValor();

        if(Input.GetKeyDown(KeyCode.W))
        {
            ImprimeValor();
            ImprimeCualEsMayor(valor1, valor2);
        }

        if (Input.GetKeyDown(KeyCode.E))
            print(Mensaje());

        if (Input.GetKeyDown(KeyCode.R))
        {
            int[] temporalArray = RandomArray();
            for (int i=0;i<temporalArray.Length;i++)
            {
                print(temporalArray[i]);
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            int multiple = Random.Range(0, 9);
            int[] temporalArray = RandomArray(multiple);

            print("El valor que multiplica es: " + multiple);

            for (int i = 0; i < temporalArray.Length; i++)
            {
                print(temporalArray[i]);
            }
        }
    }

    //Paso 1 - Función void Sencilla
    void ImprimeValor()
    {
        int tempValue = RandomValue();
        print("Valor temporal es: " + tempValue);
    }

    void ImprimeValorDoble()
    {
        valor1 = RandomValue();
        valor2 = RandomValue();
    }

    //Paso 2 - Función void con Parámetros
    void ImprimeCualEsMayor(int val1,int val2)
    {
        if (val1 > val2)
            print("El valor 1 es MAYOR que el valor 2");
        else if (val1 == val2)
            print("El valor 1 es IGUAL que el valor 2");
        else
            print("El valor 1 es MENOR que el valor 2");
    }

    //Paso 3 - Función con tipo
    int RandomValue()
    {
        return Random.Range(0, 1000);
    }

    int RandomValue(int multiple)
    {
        int temp = Random.Range(0, 1000);
        temp = temp * multiple;

        return temp;
    }

    string Mensaje()
    {
        return "Me gustan los juegos de nintendo";
    }
    int[] RandomArray()
    {
        int[] tempArray = new int[5];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = RandomValue();
        }

        return tempArray;
    }
    int[] RandomArray(int multiple)
    {
        int[] tempArray = new int[5];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = RandomValue(multiple);
        }

        return tempArray;

    }
}
