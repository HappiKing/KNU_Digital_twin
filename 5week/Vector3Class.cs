using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(100,100,100), 1f);
        //transform.position = Vector3.Lerp(transform.position, new Vector3(100, 100, 100), 0.1f);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 180), 0.05f);
    }
}
