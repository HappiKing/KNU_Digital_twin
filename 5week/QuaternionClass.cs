using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class QuaternionClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Quaternion x = " + transform.rotation.x);
        Debug.Log("Degree x = " + transform.eulerAngles.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(180,0,0), 0.01f);
    }
}
