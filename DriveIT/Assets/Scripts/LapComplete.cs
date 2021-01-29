using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliDisplay;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public int lapsDone;
    public float rawTime;
    public GameObject raceFinish;

    

    void OnTriggerEnter(Collider other)
    {
        lapsDone++;
        rawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.rawTime <= rawTime)
        {


            if (LapTimeManager.secondCount <= 9)
            {
                secDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
            }
            else
            {
                secDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";

            }
            if (LapTimeManager.minuteCount <= 9)
            {
                minDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
            }
            else
            {
                minDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ":";

            }
            milliDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliCount;
        }
        if (ModeSelection.raceMode == 2)
        {
            YellowScore.coin.SetActive(true);
        }

        PlayerPrefs.SetInt("MinSave", LapTimeManager.minuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.secondCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.milliCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);
        LapTimeManager.minuteCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.milliCount = 0;
        LapTimeManager.rawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + lapsDone;
        HalfLapTrig.SetActive(true);
        lapCompleteTrig.SetActive(false);
    }
    void Update()
    {
        if (lapsDone == 2)
        {
            raceFinish.SetActive(true);
        }
    }
}