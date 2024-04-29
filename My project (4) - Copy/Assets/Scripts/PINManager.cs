using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PINManager : MonoBehaviour
{

    
    string code = "";
    public string solution = "1899";
    public int attempts = 3;
    int strikes = 0;

    public TMP_Text promptText;
    public TMP_Text PIN_display;

    public TMP_Text alarmTimeDisplay;

    public string taskDesc = "";
    public string successDesc = "";

    public float alarmStartTime = 60.0f * 5;
    public float alarmTimePassed = 0.0f;
    private float alarmPenaltyTime = 10.0f;

    private bool penalty = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.puzzle1Complete && !GameManager.puzzle2Complete) {
            // start alarm timer after door unlocked
            alarmTimePassed = alarmTimePassed + Time.deltaTime;

            alarmTimeDisplay.SetText(FormatTime(alarmStartTime - alarmTimePassed));


            if(alarmTimePassed > alarmStartTime && !penalty) {
                GameManager.SubTime(60 * 30);
                penalty = true;
                PIN_display.text = "Authorities Alerted";
            }
        }
    }

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

    public void pushInput(string input) {
        if(!(code.Length >= solution.Length)) {
            code += input;
            PIN_display.text = code;
        }
    }

    public void enterCode() {
        if(code == solution && !penalty) {

            promptText.text = successDesc;
            // do something here
            GameManager.setPuzzle2(true);
        }
        else if (code != solution && !penalty ) {
            strikes += 1;
            PIN_display.text = "Incorrect Code";
            code = "";
        }
        else {
            PIN_display.text = "Authorities Alerted";
        }
    }

    public void delCode() {
        code = "";
        PIN_display.text = code;
    }

}
