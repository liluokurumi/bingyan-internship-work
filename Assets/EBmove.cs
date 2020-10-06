using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBmove : MonoBehaviour
{
    GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject FS = this.transform.parent.gameObject;
        GameObject GFS = FS.transform.parent.gameObject;
        other = GFS.transform.Find("SHead").gameObject;
        string name1 = gameObject.name;
        string n = name1.Substring(5, name1.Length - 5);
        int n1 = Convert.ToInt32(n);
        Queue<Vector3> H1 = other.GetComponent<Emove>().Hposition;
        Vector3[] arr = new Vector3[1000];
        H1.CopyTo(arr, 0);
        gameObject.GetComponent<Transform>().position = arr[1000 - n1 * 3];
    }
}
