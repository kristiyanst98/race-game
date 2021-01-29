using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameToMenu : MonoBehaviour
{
    

   
    void Update()
    {
        if (Input.GetButtonDown("ToMainMenu"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
