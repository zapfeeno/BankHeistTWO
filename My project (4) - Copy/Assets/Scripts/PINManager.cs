using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PINManager : MonoBehaviour
{

    
    string code = "";
    public string solution = "1899";
    public int attempts = 3;
    int strikes = 0;

    public TMP_Text promptText;
    public TMP_Text PIN_display;

    public string taskDesc = "";
    public string successDesc = "";

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

            promptText.text = successDesc;
            // do something here
            GameManager.setPuzzle2(true);
        }
        else {
            strikes += 1;
            PIN_display.text = "Incorrect. Attempts remaining before penalty: " + (attempts-strikes);
            code = "";
            if(strikes >= attempts) {
                PIN_display.text = "Max attempts reached.  Penalty for further incorrect attempts.";
                // do something here
                GameManager.SubTime(60 * 1);
            }
        }
    }

    public void delCode() {
        code = "";
        PIN_display.text = code;
    }

}
