using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //Usando arreglos
    //public int[] variables = new int[] { 5, 9, 8, 4, 3, 1, 2 };
    public int[] variables2 = new int[10];
    public int index;
<<<<<<< HEAD
    void Awake()
    {
        //Asignar un valor entre 0 y 999
        //print("Cantidad de elementos en mi arreglo: " + variables2.Length);

        ////Primer elemento de un arreglo es el index 0
        //print("Primer elemento de un arreglo: " + variables2[0]);

        ////último elemento de un arreglo es el que tiene index variables2.Length-1
        //print("Último elemento de un arreglo: " + variables2[variables2.Length - 1]);
=======
    void Start()
    {
        //Asignar un valor entre 0 y 999
        print("Cantidad de elementos en mi arreglo: " + variables2.Length);

        //Primer elemento de un arreglo es el index 0
        print("Primer elemento de un arreglo: " + variables2[0]);

        //último elemento de un arreglo es el que tiene index variables2.Length-1
        print("Último elemento de un arreglo: " + variables2[variables2.Length - 1]);
>>>>>>> cbf8a23d502c034e3b9f0dac3d8f849c301aedc0
    }

    private void Update()
    {
<<<<<<< HEAD
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    variables2[index] = Random.Range(0, 1000);
        //    print(variables2[index]);
        //}
=======
        if (Input.GetKeyDown(KeyCode.Space))
        {
            variables2[index] = Random.Range(0, 1000);
            print(variables2[index]);
        }
>>>>>>> cbf8a23d502c034e3b9f0dac3d8f849c301aedc0
    }
}
