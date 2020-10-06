using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num1 = gameObject.GetComponent<length>().num2;
        GameObject FS = this.transform.parent.gameObject;
        GameObject FSB = FS.transform.Find("SBody").gameObject;
        for (int n = 1; n <= num1; n += 1)
        {
            print("work");
            string name1 = "SBody" + n;
            if (FSB.transform.Find(name1))
            {

            }
            else
            {
                print("work");
                GameObject PrefabsSBody = Resources.Load("ESBody") as GameObject;
                GameObject NSBody = Instantiate(PrefabsSBody, null, true);
                NSBody.transform.parent = FSB.transform;
                NSBody.name = "SBody" + n;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.name);
        gameObject.GetComponent<length>().Fpoint += 1;
        GameObject.Destroy(other.gameObject);


    }
}
