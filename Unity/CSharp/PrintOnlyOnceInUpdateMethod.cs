using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintOnlyOnceInUpdateMethod : MonoBehaviour
{
    float randomValue;
    float storeFirstValue;
    bool functionExecuted = false;

    void Update()
    {
        GenerateRandomValue();
        PrintOnlyTheFirstGeneratedValue();
    }

    /******************************************************************************************************
    * Example function used in the Update method that will set a random value to "randomValue" every frame.
    * *****************************************************************************************************/
    void GenerateRandomValue()
    {
        randomValue = Random.Range(0, 10);
    }

    /***************************************************************************************************************
    * Print function that will only print the first random value that is set when GenerateRandomValue() is executed.
    * **************************************************************************************************************/
    void PrintOnlyTheFirstGeneratedValue()
    {
        if (!functionExecuted)
        {
            functionExecuted = true;
            storeFirstValue = randomValue;
            print("The first random value I got on execution is : " + storeFirstValue);
        }
        /******************************************************************
        * functionExecuted now being true, no other values will be printed.
        * ****************************************************************/
    }
}
