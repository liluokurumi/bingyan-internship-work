using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows.WebCam;

public class move : MonoBehaviour
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
        Vector2 MPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 SHeadPosition = gameObject.GetComponent<Transform>().position;
        Vector2 LSHeafPosition = SHeadPosition;
        Vector2 APosition = MPosition - SHeadPosition;
        transform.position += new Vector3(APosition.normalized.x*Time.deltaTime*10, APosition.normalized.y*Time.deltaTime*10, 0);
        Hposition.Enqueue(gameObject.GetComponent<Transform>().position);
        if (Hposition.Count == 1000)
        {
            Hposition.Dequeue();
        };
        






    }
}
