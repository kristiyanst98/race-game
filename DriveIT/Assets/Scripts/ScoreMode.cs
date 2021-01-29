using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMode : MonoBehaviour
{
    public int modeSelection;
    public GameObject raceUI;
    public GameObject scoreUI;
    public GameObject AICar;
    public static int currentScore;
    public int internalScore;
    public GameObject scoreValue;
    public GameObject coins;
    public GameObject lapRequire;
    public GameObject posDisplay;
    void Start()
    {
        modeSelection = ModeSelection.raceMode;
        if (modeSelection == 1)
        {
            lapRequire.SetActive(false);
            posDisplay.SetActive(false);
            raceUI.SetActive(false);
            scoreUI.SetActive(true);
            AICar.SetActive(false);
            coins.SetActive(true);
        }
    }


    void Update()
    {
        internalScore = currentScore;
        scoreValue.GetComponent<Text>().text = "" + internalScore;
    }

}
