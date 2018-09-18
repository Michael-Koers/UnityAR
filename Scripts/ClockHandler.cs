using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandler : MonoBehaviour
{

    public GameObject secondsPiv;
    public GameObject minutesPiv;
    public GameObject hoursPiv;

    private int seconds;
    private int minutes;
    private int hours;

    private bool isPaused = false;

    // Use this for initialization
    void Start()
    {
        SyncTime();
        Debug.Log(string.Format("Starting time is {0}:{1}:{2}", hours, minutes, seconds));
        InvokeRepeating("UpdateClock", 0, 1);
    }


    private void UpdateClock()
    {
        seconds++;
        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
        if (minutes >= 60)
        {
            minutes = 0;
            hours++;
        }
        if(hours >= 24)
        {
            hours = 0;
        }

        secondsPiv.transform.localEulerAngles = new Vector3(0, 0, -(360 / 60) * seconds);
        minutesPiv.transform.localEulerAngles = new Vector3(0, 0, -(360 / 60) * minutes);
        hoursPiv.transform.localEulerAngles = new Vector3(0, 0, -(360 / 12) * hours);
    }

    private void OnApplicationPause(bool pause)
    {
        Debug.Log("Application changed Pause state");

        if (pause)
        {
            isPaused = true;
        }
        else if(isPaused && !pause)
        {
            isPaused = false;
            SyncTime();
        }
    }

    private void SyncTime()
    {
        seconds = System.DateTime.Now.Second;
        minutes = System.DateTime.Now.Minute;
        hours = System.DateTime.Now.Hour;
    }
}
