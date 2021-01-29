using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class RaceFinish : MonoBehaviour
{
    public GameObject car;
    public GameObject finishCam;
    public GameObject viewModes;
    public GameObject LevelMusic;
    public GameObject completeTrig;
    public AudioSource finishMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (TimeMode.isTimeMode)
        {
            
            //we are in Time Mode
        }
        else
        {
            //Race mode
            this.GetComponent<BoxCollider>().enabled = false;
            car.SetActive(false);
            completeTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;
            car.SetActive(true);
            finishCam.SetActive(true);
            LevelMusic.SetActive(false);
            viewModes.SetActive(false);
            finishMusic.Play();
            GlobalCash.totalCash += 100;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.totalCash);
        }
    }
}
