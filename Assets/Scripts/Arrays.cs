using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour

{
	//Variables
	private float[] v1,
				    v2;

	public int dim;

	// Start is called before the first frame update
	void Start()
    {
		if(dim >= 1 && dim <= 10)
        {
			AddContentV1();
			AddContentV2();
			Sum();
			Subtract();
			ProductOfAVector();
			Debug.Log("|v1| = " + Module(v1));
			Debug.Log("|v2| = " + Module(v2));
			Distance();
			AngleBetweenTwoVectors();
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


	//Add values ​​to v1 and v2
	void AddContentV1()
    {
		v1 = new float[dim];

		string contentV1 = "";

		for (int i = 0; i < dim; i++)
		{
			v1[i] = Random.Range(0, 100);
			contentV1 += v1[i] + ", ";
		}

		Debug.Log("v1 = [" + contentV1.Substring(0, contentV1.Length - 2) + "]");

	}

	void AddContentV2()
    {
		v2 = new float[dim];

		string contentV2 = "";


		for (int i = 0; i < dim; i++)
		{
			v2[i] = Random.Range(0, 100);
			contentV2 += v2[i] + ", ";
		}

		Debug.Log("v2 = [" + contentV2.Substring(0, contentV2.Length - 2) + "]");
	}

	//Operations with v1 and v2
	void Sum()
	{
		float[] sum = new float[dim];
		string result = "";
			   

		for (int i = 0; i < v1.Length; i++)
		{
			sum[i] = v1[i] + v2[i];
			result += sum[i] + ", ";
		}

		Debug.Log("v1 + v2= [" + result.Substring(0, result.Length - 2) + "]");

	}

	void Subtract()
	{
		float[] subtract = new float[dim];
		string result = "";


		for (int i = 0; i < v1.Length; i++)
		{
			subtract[i] = v1[i] - v2[i];
			result += subtract[i] + ", ";
		}

		Debug.Log("v1 - v2= [" + result.Substring(0, result.Length - 2) + "]");

	}

	void ProductOfAVector()
	{
		float[] product = new float[dim];
		string result = "";
		int number = Random.Range(1, 10);


		for (int i = 0; i < v1.Length; i++)
		{
			product[i] = number * v1[i];
			result += product[i] + ", ";
		}

		Debug.Log(number + " * v1= [" + result.Substring(0, result.Length - 2) + "]");

	}

	float DotProductOfTwoVectors()
	{
		float[] product = new float[dim];
		string result = "";
		float scalarProduct = 0;


		for (int i = 0; i < v1.Length; i++)
		{
			product[i] = v1[i] * v2[i];
			scalarProduct += product[i];
			result += product[i] + ", ";
		}

		Debug.Log("v1 * v2= [" + result.Substring(0, result.Length - 2) + "]");
		Debug.Log("Σ(v1 * v2)= [" + scalarProduct + "]");

		return scalarProduct;

	}

	float Module(float[] array)
    {
		float result = 0;

		for (int i = 0; i < array.Length; i++)
		{
			result += Mathf.Pow(array[i], 2);
		}

		result = Mathf.Sqrt(result);		

		return result;
	}


	void Distance()
    {
		float[] subtract = new float[dim];
		float result = 0;


		for (int i = 0; i < v1.Length; i++)
		{
			subtract[i] = v1[i] - v2[i];
			result += Mathf.Pow(subtract[i], 2);
		}

		Debug.Log("dist(v1, v2) = " + Mathf.Sqrt(result));
	}

	void AngleBetweenTwoVectors()
    {
		float result = Mathf.Acos(DotProductOfTwoVectors() / (Module(v1) * Module(v2)));

		Debug.Log("Angle(v1, v2) = " + result);
	}
}
