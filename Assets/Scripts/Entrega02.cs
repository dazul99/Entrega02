using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega02 : MonoBehaviour
{
    //EJERCICIO 1

    [SerializeField] private float num1;
    [SerializeField] private float num2;

    //EJERCICIO 4
    private bool comp;

    //EJERCICIO 5
    private string name = "David";

    //EJERCICIO 7
    [SerializeField] private int ent1;
    [SerializeField] private int ent2;

    void Start()
    {
        //EJERCICIO 2
        Debug.Log("La suma de los dos números reales es" + (num1 + num2));

        //EJERCICIO 3
        if(num1 >= num2)
        {
            Debug.Log("la primera variable es mayor o igual a la segunda");
        }
        else
        {
            Debug.Log("la primera variable es menor que la segunda");
        }

        //EJERCICIO 4
        comp = num1>=num2;

        //EJERCICIO 6
        Debug.Log("Bienvenido, " + name);

        //EJERCICIO 8
        Debug.Log(ent1 + " % " + ent2 + " = " + (ent1 % ent2));

        //EJERCICIO 9
        if (name)
        {

        }
    }
}
