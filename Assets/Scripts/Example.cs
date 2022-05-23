using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //Mis variables chulis
    private float[] v1,
                    v2;

    public int dim;

    // Start is called before the first frame update
    void Start()
    {
        if (dim >= 1 && dim <= 100)
        {
            AddContentV1();
            AddContentV2();
            Sum();
            Subtract();
            ProductOfAVector();
            //DotProductOfTwoVectors();
            Debug.Log("|V1| = " + Module(v1));
            Debug.Log("|V2| = " + Module(v2));
            Distance();
            Angle();
        }
        else
        {
            Debug.Log("Solo puedes introducir valores entre 1 y 100.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddContentV1()
    {
        v1 = new float[dim];
        string result = "";

        for(int i = 0; i < dim; i++)
        {
            v1[i] = Random.Range(0, 100);
            result += v1[i] + ", ";//result = result +...
        }

        Debug.Log("Vector 1 = [" + result.Substring(0, result.Length - 2) + "]");
    }

    void AddContentV2()
    {
        v2 = new float[dim];
        string result = "";

        for (int i = 0; i < dim; i++)
        {
            v2[i] = Random.Range(0, 100);
            result += v2[i] + ", ";//result = result +...
        }

        Debug.Log("Vector 2 = [" + result.Substring(0, result.Length - 2) + "]");
    }

    void Sum()
    {
        float[] aux = new float[dim];
        string result = "";

        for (int i = 0; i < dim; i++)
        {
            aux[i] = v1[i] + v2[i];
            result += aux[i] + ", ";
        }

        Debug.Log("V1 + V2 = [" + result.Substring(0, result.Length - 2) + "]");
    }

    void Subtract()
    {
        float[] aux = new float[dim];
        string result = "";

        for (int i = 0; i < dim; i++)
        {
            aux[i] = v1[i] - v2[i];
            result += aux[i] + ", ";
        }

        Debug.Log("V1 - V2 = [" + result.Substring(0, result.Length - 2) + "]");
    }

    void ProductOfAVector()
    {
        float[] aux = new float[dim];
        string result = "";
        int random = Random.Range(1, 10);

        for (int i = 0; i < dim; i++)
        {
            aux[i] = random * v2[i];
            result += aux[i] + ", ";
        }

        Debug.Log(random + " * V2 = [" + result.Substring(0, result.Length - 2) + "]");
    }

    float DotProductOfTwoVectors()
    {
        float[] aux = new float[dim];
        string result = "";
        float scalarProduct = 0;

        for (int i = 0; i < dim; i++)
        {
            aux[i] = v1[i] * v2[i];
            scalarProduct += aux[i];
            result += aux[i] + ", ";
        }

        Debug.Log("V1 * V2 = [" + result.Substring(0, result.Length - 2) + "]");
        Debug.Log("Sumatoria de V1 * V2 = [" + scalarProduct + "]");

        return scalarProduct;
    }

    float Module(float[] array)
    {
        float result = 0;

        for (int i = 0; i < dim; i++)
        {
            result += Mathf.Pow(array[i], 2);
        }

        result = Mathf.Sqrt(result);

        return result;
    }

    void Distance()
    {
        float[] aux = new float[dim];
        float result = 0;

        for (int i = 0; i < dim; i++)
        {
            aux[i] = v1[i] - v2[i];
            result = Module(aux);            
        }

        Debug.Log("|V1 - V2| = [" + result + "]");
    }

    void Angle()
    {
        float result = Mathf.Acos(DotProductOfTwoVectors() / (Module(v1) * Module(v2)));

        Debug.Log("Angle(V1, V2) = " + result);
    }

}
