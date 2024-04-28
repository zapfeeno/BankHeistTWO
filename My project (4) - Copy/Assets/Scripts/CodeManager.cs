using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodeManager : MonoBehaviour
{

    public TMP_Text PIN_display;
    string code = "";
    public string solution = "1234";
    public int attempts = 3;
    int strikes = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushInput(string input) {
        if(!(code.Length >= solution.Length)) {
            code += input;
            PIN_display.text = code;
        }
    }

    public void enterCode() {
        if(code == solution) {
            PIN_display.text = "Solved!";
            // do something here
            GameManager.setPuzzle2(true);
        }
        else {
            strikes += 1;
            PIN_display.text = "Incorrect. Attempts remaining: " + (attempts-strikes);
            code = "";
            if(strikes >= attempts) {
                PIN_display.text = "Max attempts reached";
                // do something here
                GameManager.SubTime(60 * 5);
            }
        }
    }

    public void delCode() {
        code = "";
        PIN_display.text = code;
    }

}
