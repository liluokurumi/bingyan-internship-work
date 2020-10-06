using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHfollow : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 ToPosition = other.GetComponent<move>().LSHeafPosition;
        Vector2 ATPosition = gameObject.GetComponent<Transform>().position;
        //Vector2 AnglePosition = ToPosition - ATPosition;
        //transform.position += new Vector3(AnglePosition.normalized.x, AnglePosition.normalized.y, 0);



    }
}
