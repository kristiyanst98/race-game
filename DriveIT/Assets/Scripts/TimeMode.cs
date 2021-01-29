using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMode : MonoBehaviour
{
    public int modeSelection;
    public GameObject AICar;
    public GameObject lapRequire;
    public GameObject posDisplay;

    public static bool isTimeMode = false;

    void Start()
    {
        modeSelection = ModeSelection.raceMode;
        if (modeSelection == 2)
        {
            posDisplay.SetActive(false);
            lapRequire.SetActive(false);
            isTimeMode = true;
            AICar.SetActive(false);
        }
    }

}
