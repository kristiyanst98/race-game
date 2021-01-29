using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlockables : MonoBehaviour
{
    public GameObject greenButton;
    public int cashValue;


    void Update()
    {
        cashValue = GlobalCash.totalCash;
        if (cashValue >= 100)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void UnlockGreen()
    {
        greenButton.SetActive(false);
        cashValue -= 100;
        GlobalCash.totalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.totalCash);
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}
