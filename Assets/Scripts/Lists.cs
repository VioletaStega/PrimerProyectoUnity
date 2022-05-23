using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    int[] nombre = new int[5];
    List<int> nombre2 = new List<int>();

    List<int> lista = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        lista.Add(2);
        lista.Add(1);
        lista.Add(20); //2, 1, 20
        lista.Remove(21);
        lista.Sort(); //1, 2, 20
        //lista.Clear(); //

        //Clear();
        string result = "";
        for (int i = 0; i < lista.Count; i++)
        {
             result += lista[i] + ", ";            
        }

        Debug.Log(result.Substring(0, result.Length - 2));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
