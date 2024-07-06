using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject Cam;
    public GameObject SpaceShip;

    float CurrRot;
    float PrevRot;
    float DeltRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime*10);
        tilt();
    }

    void tilt()
    {
        CurrRot = Cam.transform.eulerAngles.y;
        DeltRot = CurrRot - PrevRot;
        PrevRot = CurrRot;

        if(DeltRot > 0)
        {
            //오른쪽으로 회전
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45), Time.deltaTime);
        }
        if (DeltRot < 0)
        {
            //왼쪽으로 회전
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45), Time.deltaTime);
        }
        else
        {
            //그대로
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0), Time.deltaTime);
        }

    }
}
