using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodeManager : MonoBehaviour
{

    
    string code = "";
    public string solution = "04151949";
    public int attempts = 3;
    int strikes = 0;

    public GameObject loginScreen;
    public TMP_Text loginText;
    public GameObject passwordScreen;
    public TMP_Text PIN_display;

    public string taskDesc = "";
    public string successDesc = "";

    void Start()
    {
        loginScreen.SetActive(true);
        passwordScreen.SetActive(false);
        
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
            passwordScreen.SetActive(false);

            loginText.text = successDesc;
            // do something here
            GameManager.setPuzzle3(true);
        }
        else {
            strikes += 1;
            PIN_display.text = "Incorrect. Attempts remaining before penalty: " + (attempts-strikes);
            code = "";
            if(strikes >= attempts) {
                PIN_display.text = "Max attempts reached";
                // do something here
                GameManager.SubTime(60 * 1);
            }
        }
    }

    public void delCode() {
        code = "";
        PIN_display.text = code;
    }

    public void openScreen() {
        if(!GameManager.puzzle3Complete) {
            passwordScreen.SetActive(true);
            loginText.text = taskDesc;
        }
    }

}
