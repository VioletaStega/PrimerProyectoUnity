using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rectangle();
        UnaryOperator();
        IntegerRandom();
        StudentNote();
        Cylinder();
        TaxiFare();
        Debug.Log("The largest of the three numbers is " + AssignMajor(3, 45, 28));
    }

    // Update is called once per frame
    void Update()
    {

    }



    void UnaryOperator()
    {
        //Declaration and initialization of variables
        int i = 8,
            a = 0,
            b = 0,
            c = 0;

        //Overwrite variables
        a = i;
        b = ++i;
        c = i;

        //Character string displayed on the screen
        Debug.Log("\t\t\tBefore\t \tDuring\t \tAfter\t");
        Debug.Log("Operator i++ \t\t" + a + "\t\t" + b + "\t\t" + c);

        //Result a=8, b=9 y c=9

    }

    void Rectangle()
    {
        //Declaration and initialization of variables
        float width = 7.3f,
              height = 5.1f,
              area = 0,
              perimeter = 0,
              diagonal = 0;

        //Calculations
        area = width * height;
        perimeter = 2 * (width + height);
        diagonal = Mathf.Sqrt(Mathf.Pow(width, 2) + Mathf.Pow(height, 2));

        //Character string displayed on the screen
        Debug.Log("The area of the rectangle is " + area + ", the perimeter is " + perimeter
                  + " and the diagonal is " + diagonal);
    }

    void Cylinder()
    {
        //Declaration and initialization of variables
        double area,
               volume;

        float radius = 6f,
              height = 4f;

        //Calculations
        area = 2 * Mathf.PI * radius * (radius + height);
        volume = Mathf.PI * Mathf.Pow(radius, 2) * height;

        //Character string displayed on the screen
        Debug.Log("The area of the cylinder is\t" + area);
        Debug.Log("The volume of the cylinder is\t" + volume);
    }

    void TaxiFare()
    {
        //Declaration and initialization of variables
        double time = 45,
               finalPrice = 40;

        //Calculations
        if (time > 30)
        {
            finalPrice = (40 + (2 * (time - 30)));
        }

        //Character string displayed on the screen		
        Debug.Log("Must pay " + finalPrice + "€");
    }

    void IntegerRandom()
    {
        //Declaration and initialization of variables
        int n = 10,
            random = Random.Range(0, n);

        //Character string displayed on the screen	
        Debug.Log("The random number between 0 and 10 is " + random);

    }

    void StudentNote()
    {
        //Declaration and initialization of variables
        double theory = 0.7d,
               practices = 0.3d,
               studentNoteTheory = 5,
               studentNotePractices = 8,
               finalGrade;

        string studentName = "Pepe";


        //Calculations
        finalGrade = (studentNoteTheory * theory) +
                  (studentNotePractices * practices);

        //Character string displayed on the screen	
        Debug.Log("The student's final grade " + studentName + " is " + finalGrade);
    }

    int AssignMajor(int numberOne, int numberTwo, int numberThree)
    {
        //Declaration and initialization of variables
        int largestNumber = 0;

        //Conditional
        if (numberOne >= numberTwo && numberOne >= numberThree)
        {
            largestNumber = numberOne;

        }
        else if (numberTwo >= numberOne && numberTwo >= numberThree)
        {
            largestNumber = numberTwo;

        }
        else
        {
            largestNumber = numberThree;
        }

        return largestNumber;
    }
}
