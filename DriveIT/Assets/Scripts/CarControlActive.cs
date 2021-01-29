using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject CarAI;

    void Start()
    {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        CarAI.GetComponent<CarAIControl>().enabled = true;
    }
}

