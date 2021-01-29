using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreMode.currentScore += 50;
        gameObject.SetActive(false);
    }
}
