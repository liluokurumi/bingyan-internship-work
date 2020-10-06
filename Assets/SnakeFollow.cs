using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject count1 = GameObject.Find("PlayerSnake");
        int num1 = count1.GetComponent<length>().num;
        string name1 = gameObject.name;
        print(name1.Length);
        string n = name1.Substring(5,name1.Length-5);
        int n1 = Convert.ToInt32(n);
        string name2 = "SBody" + (n1 - 1);
        GameObject LSBody = GameObject.Find(name2);
        //print(n1);
        if (n1 <= num1)
        {
            GameObject PrefabsSBody = Resources.Load("Circle") as GameObject;
            GameObject NSBody = Instantiate(PrefabsSBody, null, true);
            GameObject SBody = GameObject.Find("SBody");
            NSBody.transform.parent = SBody.transform;
            n1++;
            NSBody.name = "SBody"+n1;
            print(n1);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        //Time.captureFramerate = 60;
        //Vector2 LSBodyPosition = gameObject.GetComponent<Transform>().position;
        //Vector2 SBPosition = otherA.GetComponent<SnakeFollow>().LSBodyPosition;
        //Vector2 LSBPosition = other.GetComponent<Transform>().position;
        //Vector2 AnglePosition = SBPosition - LSBPosition;
        //transform.position








    }
}
