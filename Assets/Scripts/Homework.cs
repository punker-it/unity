using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Homework : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int firstNumber = 45;
        int secondNumber = 78;
        int summ = firstNumber + secondNumber;
        int difference = firstNumber - secondNumber;
        double myDecimal = 3.14;
        string myName = "Slava";

        Console.WriteLine(firstNumber);
        Console.WriteLine(myDecimal);
        Console.WriteLine("Меня зовут "+myName);
        Console.WriteLine(firstNumber+" + "+secondNumber+" = "+ summ);
        Console.WriteLine(firstNumber+" - "+secondNumber+" = "+ difference);

        Debug.Log(firstNumber);
        Debug.Log(myDecimal);
        Debug.Log("Меня зовут "+myName);
        Debug.Log(firstNumber+" + "+secondNumber+" = "+ summ);
        Debug.Log(firstNumber+" - "+secondNumber+" = "+ difference);


        for(int i = 0;i<myName.Length;i++) {
            Debug.Log(myName[i]);
        }

        foreach (char rteretr in myName) {
             Debug.Log(rteretr);
        }
    }
}
