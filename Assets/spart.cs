using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject count1 = GameObject.Find("PlayerSnake");
        int num1 = count1.GetComponent<length>().num;
        string name1 = gameObject.name;
        string n = name1.Substring(5, name1.Length - 5);
        int n1 = Convert.ToInt32(n);
        if (n1 < num1)
        {
            
        }
        
    }
}
