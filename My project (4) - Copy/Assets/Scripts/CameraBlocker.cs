using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBlocker : MonoBehaviour
{

    public GameObject playerFeedback;

    void Start() {
        playerFeedback.SetActive(false);
    }

    void Update() {
        if(GameManager.puzzle3Complete) {
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other) {

        // add feedback to let player know they are in camera view
        // (!) metal gear solid type thing
        if(other.gameObject.tag == "Player") {
            GameManager.SubTime(Time.deltaTime * 3);
            //doorMaterial.color = Color.green;
        }

    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            playerFeedback.SetActive(true);
            //doorMaterial.color = Color.green;
        }

    }

    void OnTriggerExit(Collider other) {

        if(other.gameObject.tag == "Player") {
            playerFeedback.SetActive(false);
            //doorMaterial.color = Color.green;
        }

    }

}
