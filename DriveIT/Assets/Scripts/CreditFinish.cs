﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CreditEnd());
    }
    IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(1);
    }
}
