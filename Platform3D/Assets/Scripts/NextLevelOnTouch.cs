﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelOnTouch : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject nextLevelMenu;
    public GameObject timeBox;
    public GameObject scoreBox;

    void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            StartCoroutine(NextLevel());
        }  
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        Time.timeScale = 0;
        nextLevelMenu.SetActive(true);
        timeBox.SetActive(false);
        scoreBox.SetActive(false);
    }
}
