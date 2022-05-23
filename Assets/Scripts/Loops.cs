using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        //LoopOf0To100WithFor();
        //LoopOf0To100WithWhile();
        //LoopOf100To0WithFor();
        //LoopOf100To0WithWhile();
        //LoopOf0ToXWithFor();
        //LoopOf0ToXWithWhile();
        //PositiveNumbersWithFor();
        //PositiveNumbersWithWhile();
        //NegativeNumbersWithFor();
        //NegativeNumbersWithWhile();
        //OddNumbersWithFor();
        //OddNumbersWithWhile();
        //EvenNumbersWithFor();
        //EvenNumbersWithWhile();
        //MultiplesOf3WithFor();
        //MultiplesOf3WithWhile();
        //MultiplesOf3And2WithFor();
        MultiplesOf3And2WithWhile();
        SumNumbersWithFor();
        SumNumbersWithWhile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Exercise 01. Show numbers from 0 to 100
    void LoopOf0To100WithFor()
    {
        for (int i = 0; i < 101; i++)
        {
            Debug.Log(i);
        }
    }

    void LoopOf0To100WithWhile()
    {
        int i = 0;

        while (i < 100)
        {
            Debug.Log(i);
            i++;
        }
    }

    //Exercise 02. Show the numbers from 100 to 0
    void LoopOf100To0WithFor()
    {
        for (int i = 100; i > -1; i--)
        {
            Debug.Log(i);
        }
    }

    void LoopOf100To0WithWhile()
    {
        int i = 100;

        while (i > -1)
        {
            Debug.Log(i);
            i--;
        }
    }

    //Exercise 03. Display the numbers from 1 to the entered number

    void LoopOf0ToXWithFor()
    {
        for (int i = 1; i < number; i++)
        {
            Debug.Log(i);
        }
    }

    void LoopOf0ToXWithWhile()
    {
        int i = 0;

        while (i < number)
        {
            Debug.Log(i);
            i++;
        }
    }

    //Exercise 04. Enter 10 numbers and display the positive numbers

    void PositiveNumbersWithFor()
    {
        int[] array = { -10, 6, -78, -4, -65, -56, 17, 80, -209, 1000 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                Debug.Log(array[i]);
            }
        }
    }

    void PositiveNumbersWithWhile()
    {
        int[] array = { -10, 6, -78, -4, -65, -56, 17, 80, -209, 1000 };

        int i = 0;

        while (i < array.Length)
        {
            if (array[i] > 0)
            {
                Debug.Log(array[i]);
            }
            i++;
        }
    }

    //Exercise 05. Enter 10 numbers and display the negative numbers

    void NegativeNumbersWithFor()
    {
        int[] array = { -10, 6, -78, -4, -65, -56, 17, 80, -209, 1000 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                Debug.Log(array[i]);
            }
        }
    }

    void NegativeNumbersWithWhile()
    {
        int[] array = { -10, 6, -78, -4, -65, -56, 17, 80, -209, 1000 };

        int i = 0;

        while (i < array.Length)
        {
            if (array[i] < 0)
            {
                Debug.Log(array[i]);
            }
            i++;
        }
    }

    //Exercise 06. Show odd numbers between 0 and 100

    void OddNumbersWithFor()
    {
        
        for (int i = 0; i < 101; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }

    void OddNumbersWithWhile()
    {        

        int i = 0;

        while (i < 101)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
            i++;
        }
    }

    //Exercise 07. Show even numbers between 0 and 100

    void EvenNumbersWithFor()
    {

        for (int i = 0; i < 101; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    void EvenNumbersWithWhile()
    {

        int i = 0;

        while (i < 101)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
            i++;
        }
    }

    //Exercise 08. Show the multiples of 3 from 0 to 100

    void MultiplesOf3WithFor()
    {

        for (int i = 0; i < 101; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    void MultiplesOf3WithWhile()
    {

        int i = 0;

        while (i < 101)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
            i++;
        }
    }

    //Exercise 09. Show the multiples of 3 and 2 between 0 and 100

    void MultiplesOf3And2WithFor()
    {

        for (int i = 0; i < 101; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    void MultiplesOf3And2WithWhile()
    {

        int i = 0;

        string result = "";

        while (i < 101)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                result += i + ", ";
            }
            i++;
        }

        Debug.Log(result.Substring(0, result.Length - 2));
    }

    //Exercise 10. Enter a number and display the sum of the numbers from 1 to the number inserted

    void SumNumbersWithFor()
    {
        int sum = 0;

        string result = "";

        for (int i = 1; i <= number; i++)
        {             
            sum += i;
            result += i + " + ";
        }

        Debug.Log(result.Substring(0, result.Length-2) + " = " + sum);

        Debug.Log("The sum between 1 to " + number + " is: " + sum);
    }

    void SumNumbersWithWhile()
    {
        int sum = 0,
            i = 1;

        string result = "";

        while (i <= number)
        {
            result += i + " + ";
            sum += i++;
            
        }

        Debug.Log(result.Substring(0, result.Length - 2) + " = " + sum);
        Debug.Log("The sum between 1 to " + number + " is: " + sum);
    }
}
