using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject redBody;
    public GameObject blueBody;
    public GameObject greenBody;
    public int carImport;

    void Start()
    {
        carImport = GlobalCar.carType;
        // 1 is red, 2 is blue, 3 is green
        if (carImport == 1)
        {
            redBody.SetActive(true);
        }
        if (carImport == 2)
        {
            blueBody.SetActive(true);
        }
        if (carImport == 3)
        {
            greenBody.SetActive(true);
        }
    }

    
}
