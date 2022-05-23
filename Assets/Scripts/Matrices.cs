using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrices : MonoBehaviour
{
	//Variables
	private float[,] m1,
					 m2;

	public int dim1,
			   dim2;

	// Start is called before the first frame update
	void Start()
    {
		if (dim1 >= 1 && dim1 <= 10 && dim2 >= 1 && dim2 <= 10)
		{
			AddContentV1();
			AddContentV2();
			Sum();
			Subtract();
		}
		else
        {
			Debug.Log("Enter values ​​between 1 and 10");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//Add values ​​to m1 and m2
	void AddContentV1()
	{
		m1 = new float[dim1, dim2];

		string contentV1 = "";

		for (int i = 0; i < dim1; i++)
		{
			for (int j = 0; j < dim2; j++)
			{
				m1[i, j] = Random.Range(0, 100);
				contentV1 += m1[i, j] + "\t"+"  ";
			}
			contentV1 += "\n\t\t";
		}

		Debug.Log("m1 =   " + contentV1);

	}

	void AddContentV2()
	{
		m2 = new float[dim1, dim2];

		string contentV2 = "";

		for (int i = 0; i < dim1; i++)
		{
			for (int j = 0; j < dim2; j++)
			{
				m2[i, j] = Random.Range(0, 100);
				contentV2 += m2[i, j] + "\t" + "  ";
			}
			contentV2 += "\n\t\t";
		}

		Debug.Log("m2 =   " + contentV2);

	}

	//Operations with m1 and m2
	void Sum()
	{
		float[,] sum = new float[dim1, dim2];
		string result = "";

		for (int i = 0; i < dim1; i++)
		{
            for (int j = 0; j < dim2; j++)
            {
				sum[i, j] = m1[i, j] + m2[i, j];
				result += sum[i, j] + "\t" + "  ";
			}
			result += "\n\t\t\t";
		}

		Debug.Log("m1 + m2 = \t" + result);

	}

	void Subtract()
	{
		float[,] subtract = new float[dim1, dim2];
		string result = "";

		for (int i = 0; i < dim1; i++)
		{
			for (int j = 0; j < dim2; j++)
			{
				subtract[i, j] = m1[i, j] - m2[i, j];
				result += subtract[i, j] + "\t" + "  ";
			}
			result += "\n\t\t\t";
		}

		Debug.Log("m1 - m2 = \t" + result);

	}
}
