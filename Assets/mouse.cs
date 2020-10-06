using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MPosition = Input.mousePosition;
        MPosition.x -= UnityEngine.Screen.width / 2;
        MPosition.y -= UnityEngine.Screen.height / 2;
        gameObject.GetComponent<Transform>().position = MPosition;

    }
}
