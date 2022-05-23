using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IsPositive();
        EvenOdd();
        NumberCondition();
        IsVowel();
        DayWeek();
        DayWeekWithSwitch();
        Month();
        MonthWithSwitch();
        SmallestNumber();
        BiggerNumber();
        IncreasingOrder();
        DecreasingOrder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Exercise 01. Enter a number and say if it is positive or negative.

    void IsPositive()
    {
        int number = -100;

        if (number > 0)
        {
            Debug.Log(number + " is positive");
        }
        else
        {
            Debug.Log(number + " is negative");
        }
    }

    //Exercise 02. Enter a number and say if it is even or odd.

    void EvenOdd()
    {
        int number = 17;

        if (number % 2 == 0)
        {
            Debug.Log(number + " is pair");
        }
        else
        {
            Debug.Log(number + " is odd");
        }
    }

    //Exercise 03. Enter two numbers and display them in ascending order.

    void NumberCondition()
    {
        int firstNumber = 86,
            secondNumber = 17;


        if (firstNumber < secondNumber)
        {
            Debug.Log("Numbers from major to minor:\n" + firstNumber + " \n " + secondNumber);
        }
        else if (firstNumber == secondNumber)
        {
            Debug.Log("They are equal!");
        }
        else
        {
            Debug.Log("Numbers from major to minor:\n" + secondNumber + " \n " + firstNumber);
        }
    }

    //Exercise 04. Enter a letter and detect if it is a vowel.
    
    void IsVowel()
    {
        char letter = 'z';

        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Debug.Log(letter + " is a vowel");
        }
        else
        {
            Debug.Log(letter + " is a constant");
        }
    }

    //Exercise 05. Enter a number from 1 to 7 and say the corresponding day of the week.

    void DayWeek()
    {
        int dayNumber = 5;

        if (dayNumber == 1)
        {
            Debug.Log("Monday");
        }
        else if (dayNumber == 2)
        {
            Debug.Log("Tuesday");
        }
        else if (dayNumber == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (dayNumber == 4)
        {
            Debug.Log("Thursday");
        }
        else if (dayNumber == 5)
        {
            Debug.Log("Friday");
        }
        else if (dayNumber == 6)
        {
            Debug.Log("Saturday");
        }
        else if (dayNumber == 7)
        {
            Debug.Log("Sunday");
        }
        else
        {
            Debug.Log("Number out of range!");
        }
    }

    void DayWeekWithSwitch()
    {
        int dayNumber = 5;

        switch (dayNumber)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
            default:
                Debug.Log("Number out of range!");
                break;

        }
    }

    //Exercise 06. Enter a number from 1 to 12 and say the name of the corresponding month.

    void Month()
    {
        int monthNumber = 5;

        if (monthNumber == 1)
        {
            Debug.Log("January");
        }
        else if (monthNumber == 2)
        {
            Debug.Log("February");
        }
        else if (monthNumber == 3)
        {
            Debug.Log("March");
        }
        else if (monthNumber == 4)
        {
            Debug.Log("April");
        }
        else if (monthNumber == 5)
        {
            Debug.Log("May");
        }
        else if (monthNumber == 6)
        {
            Debug.Log("June");
        }
        else if (monthNumber == 7)
        {
            Debug.Log("July");
        }
        else if (monthNumber == 8)
        {
            Debug.Log("August");
        }
        else if (monthNumber == 9)
        {
            Debug.Log("September");
        }
        else if (monthNumber == 10)
        {
            Debug.Log("October");
        }
        else if (monthNumber == 11)
        {
            Debug.Log("November");
        }
        else if (monthNumber == 12)
        {
            Debug.Log("December");
        }
        else
        {
            Debug.Log("Number out of range!");
        }
    }

    void MonthWithSwitch()
    {
        int dayNumber = 5;

        switch (dayNumber)
        {
            case 1:
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("February");
                break;
            case 3:
                Debug.Log("March");
                break;
            case 4:
                Debug.Log("April");
                break;
            case 5:
                Debug.Log("May");
                break;
            case 6:
                Debug.Log("June");
                break;
            case 7:
                Debug.Log("July");
                break;
            case 8:
                Debug.Log("August");
                break;
            case 9:
                Debug.Log("September");
                break;
            case 10:
                Debug.Log("October");
                break;
            case 11:
                Debug.Log("November");
                break;
            case 12:
                Debug.Log("December");
                break;
            default:
                Debug.Log("Number out of range!");
                break;

        }
    }

    //Exercise 07. Enter 3 numbers and display them on the screen from smallest to highest.

    void SmallestNumber()
    {
        int smallerNumber,
            mediumNumber,
            biggerNumber, 
            numberOne = 200,
            numberTwo = 400,
            numberThree = 8;


        if (numberOne < numberTwo)
        {
            smallerNumber = numberOne;
            biggerNumber = numberTwo;
        }
        else
        {
            smallerNumber = numberTwo;
            biggerNumber = numberOne;
        }

        
        if (numberThree < smallerNumber)
        {
            mediumNumber = smallerNumber; 
            smallerNumber = numberThree; 
        }
        else 
        {
            if (numberThree > biggerNumber) 
            {
                mediumNumber = biggerNumber; 
                biggerNumber = numberThree; 
            }
            else 
            {
                mediumNumber = numberThree;
            }
        }

        Debug.Log("Numbers from major to minor:\n" + smallerNumber + " \n " + mediumNumber 
                  + " \n " + biggerNumber);
    }

    //Exercise 08. Enter 3 numbers and display them on the screen from highest to lowest.

    void BiggerNumber()
    {
        int smallerNumber,
            mediumNumber,
            biggerNumber,
            numberOne = 2000,
            numberTwo = 400,
            numberThree = 80000;


        if (numberOne < numberTwo)
        {
            smallerNumber = numberOne;
            biggerNumber = numberTwo;
        }
        else
        {
            smallerNumber = numberTwo;
            biggerNumber = numberOne;
        }


        if (numberThree < smallerNumber)
        {
            mediumNumber = smallerNumber;
            smallerNumber = numberThree;
        }
        else
        {
            if (numberThree > biggerNumber)
            {
                mediumNumber = biggerNumber;
                biggerNumber = numberThree;
            }
            else
            {
                mediumNumber = numberThree;
            }
        }

        Debug.Log("Numbers from major to minor:\n" + biggerNumber + " \n " + mediumNumber
                  + " \n " + smallerNumber);
    }

    //Exercise 09. Enter three numbers and detect if they have been entered in increasing order.

    void IncreasingOrder()
    {
        int numberOne = 1,
            numberTwo = 2,
            numberThree = 3;

        if (numberOne <= numberTwo && numberTwo <= numberThree)
        {
            Debug.Log("The order of the numbers entered is increasing.");
        }
        else
        {
            Debug.Log("The order of the numbers entered is NOT increasing.");
        }
    }

    //Exercise 10. Enter three numbers and detect if they have been entered in order decreasing.

    void DecreasingOrder()
    {
        int numberOne = 1,
            numberTwo = 2,
            numberThree = 3;

        if (numberOne >= numberTwo && numberTwo >= numberThree)
        {
            Debug.Log("The order of the numbers entered is decreasing.");
        }
        else
        {
            Debug.Log("The order of the numbers entered is NOT decreasing");
        }
    }
}
