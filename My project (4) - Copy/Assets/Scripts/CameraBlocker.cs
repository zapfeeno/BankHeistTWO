using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBlocker : MonoBehaviour
{

    void Start() {

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

}
