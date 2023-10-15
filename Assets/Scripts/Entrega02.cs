using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega02 : MonoBehaviour
{
    //EJERCICIO 1

    [SerializeField] private float num1;
    [SerializeField] private float num2;

    //Se crean dos variables para el ejercicio

    //EJERCICIO 4
    private bool comp;
    //se crea una variable para introducir el resultado de una comparación

    //EJERCICIO 5
    private string name = "David";
    //creo una variable con mi nombre

    //EJERCICIO 7
    [SerializeField] private int ent1;
    [SerializeField] private int ent2;
    //se crean dos variables enteras

    void Start()
    {
        //EJERCICIO 2
        Debug.Log("La suma de los dos números reales es " + (num1 + num2));
        //Debería salir por pantalla la suma de num1 y num2
        //en mi caso que son 10 y 3 respectivamente sale "La suma de los dos números reales es 13"

        //EJERCICIO 3
        if(num1 >= num2)
        {
            Debug.Log("la primera variable es mayor o igual a la segunda");
        }
        else
        {
            Debug.Log("la primera variable es menor que la segunda");
        }

        //Aqui se comprueba si num1 es mayor o igual que num2 y dependiendo de si lo es o no sale un mensaje u otro

        //EJERCICIO 4
        comp = num1>=num2;
        //Aqui se guardaría en la variable creada anteriormente el resultado de num1 >= num2
        // en mi caso que num1 = 10 y num2 = 3 sería true

        //EJERCICIO 6
        Debug.Log("Welcome, " + name);
        //Tiene que salir "Welcome, David

        //EJERCICIO 8
        Debug.Log(ent1 + " % " + ent2 + " = " + (ent1 % ent2));
        // En este ejercicio saldría por pantalla ent1 % ent2 = ent1%ent2
        //en mi caso que ent1 = 31  y ent2 = 12 saldría "31 % 12 = 7"

        
        //EJERCICIO 9
        Debug.Log("Hello! My name is " + name);
        //en este caso saldría por consola "Hello! My name is David"

    }
}
