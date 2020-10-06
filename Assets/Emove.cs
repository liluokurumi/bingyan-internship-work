using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emove : MonoBehaviour
{
    public Queue<Vector3> Hposition = new Queue<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.captureFramerate = 60;
        transform.position += new Vector3(Time.deltaTime * 10, 0, 0);
        Hposition.Enqueue(gameObject.GetComponent<Transform>().position);
        if (Hposition.Count == 1000)
        {
            Hposition.Dequeue();
        };


    }
}
