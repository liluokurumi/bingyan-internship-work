using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 10000;
        for (int n = 0; n <= i; n += 1)
        {
            GameObject Prefabsfood = Resources.Load("food") as GameObject;
            GameObject Nfood = Instantiate(Prefabsfood, null, true);
            GameObject SBody = GameObject.Find("foodcontrol");
            Nfood.transform.parent = SBody.transform;
            Nfood.GetComponent<Transform>().position = new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), 0);

            Nfood.name = "food" + n;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}