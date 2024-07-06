using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class raycast : MonoBehaviour
{
    public Image Rectangle;
    float timeE;

    void Start()
    {

    }

    void Update()
    {

    }

    void raycasting()
    {
        RaycastHit hit; // 변수 선언, raycast에 부딛힌 오브젝트의 정보가 담김
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);
        
        if(Physics.Raycast(transform.position, forward, out hit))
        {  
            timeE = Time.deltaTime + timeE;
            Rectangle.fillAmount = timeE / 3;

            if (timeE >= 3)
            {
                timeE = 3;
                // hit.transform.GetComponent<Button>.onClick.invoke();

            }
            else
            {
                timeE = timeE - Time.deltaTime;
                Rectangle.fillAmount = timeE / 3;

                if(timeE <= 0)
                {
                    timeE = 0;
                }
            }
            // hit.transform.GetComponent<Button>.onClick.invoke();
            // Debug.Log("Hit");

        }
        Debug.DrawRay(transform.position, forward, Color.red);
    }
}
