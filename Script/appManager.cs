using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appManager : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
    }
}
