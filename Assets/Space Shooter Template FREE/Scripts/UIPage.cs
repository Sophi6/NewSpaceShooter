using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPage : MonoBehaviour
{
   // public GameObject GameOverScreenBG;
  

    public void PlayClick()
        {
            SceneManager.LoadScene("Level9");
	}
    public void ExitClick()
    {
        SceneManager.LoadScene("Manuscene");
    }
}
