using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonCast : MonoBehaviour
{
    public void toVideoScene()
    {
        SceneManager.LoadScene("360Video");
    }
}
