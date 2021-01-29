using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelection : MonoBehaviour
{
    public static int raceMode; //0-race, 1-score, 2-time
    public GameObject trackSelect;

    public void ScoreMode()
    {
        raceMode = 1;
        trackSelect.SetActive(true);
    }
    public void TimeMode()
    {
        raceMode = 2;
        trackSelect.SetActive(true);
    }

    public void RaceMode()
    {
        raceMode = 0;
        trackSelect.SetActive(true);
    }
}
