using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{

    public int rotateSpeed;

    private void Start()
    {
        rotateSpeed = 2;
    }
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
