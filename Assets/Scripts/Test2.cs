using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public int value; //Valores númericos sin punto decimal (-25550, 20, 0, -80, 9000)
    public float pointValue; //Valores númericos con punto decimal (-85005.9f, 100f, 8734.123f)
    public string wordChain; //Cadenas de palabras (Letras, números, signos, espacios en blanco, etc) //"Adrián Cruz", "Esta facil", "Esta complicado", "Hola como estas"
    public bool conditional; //Valor verdadero o falso (true o false)

    // Start is called before the first frame update
    void Start()
    {
        value = 123456;
        pointValue = 9825.257f;

        print("Value " + value);
        print("Value " + pointValue);
        print("wordChain " + wordChain);
        print("conditional " + conditional);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
