using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{

    public void SampleScene() {
        Debug.Log("test");
        SceneManager.LoadScene("TestScene");
    }

    public void startMenu() {
        Debug.Log("back to start");
        SceneManager.LoadScene("SampleScene");
    }


}
