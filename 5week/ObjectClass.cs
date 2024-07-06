using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(this.gameObject); // 절대 업데이트에 넣으면 안된다. 
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
