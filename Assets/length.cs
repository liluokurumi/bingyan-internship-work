using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class length : MonoBehaviour
{
    public int num;
    public int Fpoint;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        Fpoint = 0;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        int Point = num * 5 + Fpoint;
        num2 = Point / 5;



        
    }
}
