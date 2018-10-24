using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausing : MonoBehaviour {

    

    public void Pause()
    {
        switch (Time.timeScale.ToString())
        {
            case "0":
                Time.timeScale = 1;
                break;
            case "1":
                Time.timeScale = 0;
                break;
            default:
                Debug.Log("Default");
                break;
        }
        
    }







}
