using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 10, 10);
        transform.rotation = Quaternion.Euler(30, 60, 90);
        transform.localScale = new Vector3(10, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward);
        transform.Rotate(Vector3.up);
    }
}
