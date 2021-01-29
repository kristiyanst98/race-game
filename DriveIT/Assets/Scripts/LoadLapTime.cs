using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int minCount;
    public int secCount;
    public float milliCount;
    public GameObject minDisplayBest;
    public GameObject secDisplayBest;
    public GameObject milliDisplayBest;

    void Start()
    {
        minCount = PlayerPrefs.GetInt("MinSave");
        secCount = PlayerPrefs.GetInt("SecSave");
        milliCount = PlayerPrefs.GetInt("MilliSave");


        
        if (secCount <= 9)
        {
            secDisplayBest.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            secDisplayBest.GetComponent<Text>().text = "" + secCount + ".";
        }
        if (minCount <= 9)
        {
            minDisplayBest.GetComponent<Text>().text = "0" + minCount + ":";
        }
        else
        {
            minDisplayBest.GetComponent<Text>().text = "" + minCount + ":";
        }

        milliDisplayBest.GetComponent<Text>().text = "" + milliCount;
    }

    
}
