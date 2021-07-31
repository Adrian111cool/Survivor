using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    public List<int> list = new List<int>();

    void Start()
    {
        print("Tamaño de una lista: " + list.Count);

        //Añadir un elemento a nuestra lista
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));

        int temp = Random.Range(0, 1000);
        list.Add(temp);

        print("Tamaño de una lista: " + list.Count);

        print("Elemento a borrar es: " + temp);
        //Eliminar según un elemento
        list.Remove(temp);
        print("Tamaño de una lista: " + list.Count);

        int tempIndex = 0;
        print("Elemento a borrar según su index es: " + list[tempIndex]);
        list.RemoveAt(tempIndex);
        print("Tamaño de una lista: " + list.Count);

        int tempLastIndex = list.Count - 1;
        print("Elemento a borrar según su index es: " + list[tempLastIndex]);
        list.RemoveAt(tempLastIndex);
        print("Tamaño de una lista: " + list.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
