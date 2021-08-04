using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_For : MonoBehaviour
{
    public int[] array = new int[5];
    public List<int> list = new List<int>();

    public Array arrayClass;
    public Lists listClass;

    void Start()
    {
        //Paso 1
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = Random.Range(0, 1000);
        //    list.Add(array[i]);
        //    print("Index " + i + " = " + array[i]);
        //}

        //Paso 2
        for (int i = 0; i < arrayClass.variables2.Length; i++)
        {
            arrayClass.variables2[i] = Random.Range(0, 1000)*2;

            listClass.list.Add(arrayClass.variables2[i]);
            print("Index " + i + " = " + arrayClass.variables2[i]);
        }

    }


    void Update()
    {
        
    }
}
