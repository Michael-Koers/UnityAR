using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour {

    Text date;
	
    // Use this for initialization
	void Start () {
        date = GetComponent<Text>();

        date.text = "" + System.DateTime.Now.Day.ToString() + " " + System.DateTime.Now.ToString("MMMM");
	}
	
}
