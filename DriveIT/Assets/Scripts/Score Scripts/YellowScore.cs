using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{
    public static GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
        ScoreMode.currentScore += 200;
        coin.SetActive(false);
    }
}
