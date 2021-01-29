using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject normalCam;
    public GameObject farCam;
    public GameObject FPCam;
    public int camMode;

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (camMode == 2)
            {
                camMode = 0;
            }

            else
            {
                camMode++;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            normalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (camMode == 1)
        {
            farCam.SetActive(true);
            normalCam.SetActive(false);
        }
        if (camMode == 2)
        {
            FPCam.SetActive(true);
            farCam.SetActive(false);
            
        }
    }
}
