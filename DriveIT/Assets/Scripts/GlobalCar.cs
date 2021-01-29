using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
   public static int carType; // 1 is red, 2 is blue, 3 is green
    public GameObject trackWindow;

    public void RedCar()
    {
        carType = 1;
        trackWindow.SetActive(true);
    }
    public void BlueCar()
    {
        carType = 2;
        trackWindow.SetActive(true);
    }
    public void GreenCar()
    {
        carType = 3;
        trackWindow.SetActive(true);
    }
}
