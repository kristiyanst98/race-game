using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject countDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject lapTimer;
    public GameObject carControls;
    public AudioSource levelMusic;
    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        lapTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        GoAudio.Play();
        levelMusic.Play();
        lapTimer.SetActive(true);
        carControls.SetActive(true);
        
    }
}
