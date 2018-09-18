using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{

    Text time;

    // Use this for initialization
    void Start()
    {
        time = GetComponent<Text>();
        InvokeRepeating("updateClock", 0, 1);
    }

    void updateClock()
    {
        time.text = System.DateTime.Now.ToString("HH:mm:ss");
    }
}
