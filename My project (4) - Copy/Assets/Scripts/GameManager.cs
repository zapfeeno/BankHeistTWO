using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{

    public static bool puzzle1Complete = false;
    public static bool puzzle2Complete = false;
    public static bool puzzle3Complete = false;
    public static bool puzzle4Complete = false;
    public static bool puzzle5Complete = false;

    public TMP_Text[] timeDisplay;


    public static float startTime = 60.0f * 60;
    public static float timePassed = 0.0f;
    private static float penaltyTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // tracking time here
    void Update()
    {
        // this is so messed up idk why i did it like this
        timePassed = startTime - penaltyTime - Time.time;
        
        for(int i = 0 ; i < timeDisplay.Length ; i++) {
            timeDisplay[i].SetText(FormatTime(timePassed));
        }
        
    }

    // formats seconds to HH:MM:ss
    string FormatTime(float timeInSeconds) {

        if(timeInSeconds < 0) {
            timeInSeconds = 0;
        }

        int hours = (int)(Math.Floor(timeInSeconds / 3600.0));
        int minutes = (int)(Math.Floor(timeInSeconds / 60.0));
        int seconds = (int)Math.Truncate(timeInSeconds % 60);
        string hString = hours.ToString();
        string mString = minutes.ToString();
        string sString = seconds.ToString();

        if(hours < 10) {
            hString = "0" + hours;
        }
        if(minutes < 10) {
            mString = "0" + minutes;
        }
        if(seconds < 10) {
            sString = "0" + seconds;
        }

        return hString + ":" + mString + ":" + sString;
    }

    public static void SubTime(float secondsLost) {
        penaltyTime = penaltyTime + secondsLost;
    }

    public static void setPuzzle1(bool isDone) {
        puzzle1Complete = isDone;
        Debug.Log("Puzzle 1 complete: " + isDone);
    }

    public static void setPuzzle2(bool isDone) {
        puzzle2Complete = isDone;
        Debug.Log("Puzzle 2 complete: " + isDone);
    }

    public static void setPuzzle3(bool isDone) {
        puzzle3Complete = isDone;
        Debug.Log("Puzzle 3 complete: " + isDone);
    }
}
