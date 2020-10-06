using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Time.captureFramerate = 60;
        Vector3 SHeadPosition = other.GetComponent<Transform>().position;
        SHeadPosition.z -= 10;
        gameObject.GetComponent<Transform>().position = SHeadPosition;
        



    }
}
