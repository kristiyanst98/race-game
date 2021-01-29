using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangeCar01Track : MonoBehaviour
{
    public GameObject theMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public int markTracker;


    void Update()
    {
        if (markTracker == 0)
        {
            theMarker.transform.position = mark01.transform.position;
        }
        if (markTracker == 1)
        {
            theMarker.transform.position = mark02.transform.position;
        }
        if (markTracker == 2)
        {
            theMarker.transform.position = mark03.transform.position;
        }
        if (markTracker == 3)
        {
            theMarker.transform.position = mark04.transform.position;
        }
        if (markTracker == 4)
        {
            theMarker.transform.position = mark05.transform.position;
        }
        if (markTracker == 5)
        {
            theMarker.transform.position = mark06.transform.position;
        }
        if (markTracker == 6)
        {
            theMarker.transform.position = mark07.transform.position;
        }
        if (markTracker == 7)
        {
            theMarker.transform.position = mark08.transform.position;
        }
        if (markTracker == 8)
        {
            theMarker.transform.position = mark09.transform.position;
        }
        if (markTracker == 9)
        {
            theMarker.transform.position = mark10.transform.position;
        }
        if (markTracker == 10)
        {
            theMarker.transform.position = mark11.transform.position;
        }
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "StrangeCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker++;
            if (markTracker == 11)
            {
                markTracker = 0;
            }
            yield return new WaitForSeconds(0.5f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
