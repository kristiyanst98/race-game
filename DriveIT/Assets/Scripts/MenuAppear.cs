using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject largeButton;
    public GameObject TextClick;
    public GameObject menuButtons;

    public void StartMenu()
    { 
        TextClick.SetActive(false);
        menuButtons.SetActive(true);
        largeButton.SetActive(false);
    }
}
