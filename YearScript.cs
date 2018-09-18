using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearScript : MonoBehaviour
{

    Text year;

    // Use this for initialization
    void Start()
    {
        year = GetComponent<Text>();

        year.text = System.DateTime.Now.Year.ToString();
    }

}
