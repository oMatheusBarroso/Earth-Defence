using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text MinText;
    public Text SecText;
    public Text DecText;

    private float startTime;

    void Start()
    {
        startTime = Time.time;
        MinText.text = SecText.text = DecText.text = "00";
    }

    void Update()
    {
        float t = Time.time - startTime;

        float minutesnum = (int)t / 60;
        float secondsnum = (int)t % 60;
        float decimalsnum = (int)(Math.Floor((t - (secondsnum + minutesnum * 60)) * 100));

        //string minutes = minutesnum.ToString();
        //string seconds = secondsnum.ToString("f0");
        //string decimals = decimalsnum.ToString("f0");

        MinText.text = ((minutesnum < 10) ? "0" + minutesnum : minutesnum.ToString());

        SecText.text = ((secondsnum < 10) ? "0" + secondsnum : secondsnum.ToString("f0"));

        DecText.text = ((decimalsnum < 10) ? "0" + decimalsnum : decimalsnum.ToString("f0"));

        //if (minutesnum < 10)
        //{
        //    TimerText.text = "0" + minutes + " : " + seconds + " : " + decimals;
        //}
        //else if (secondsnum < 10)
        //{
        //    TimerText.text = minutes + " : " + "0" + seconds + " : " + decimals;
        //}
        //else if(minutesnum < 10 && secondsnum < 10)
        //{
        //    TimerText.text = "0" + minutes + " : 0" + seconds + " : " + decimals;
        //}
    }
}
