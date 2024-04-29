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

    void OnTriggerEnter(Collider other) {


        if(other.gameObject.tag == "Player") {
            Debug.Log("Disable cameras first");
            //doorMaterial.color = Color.green;
        }


    }

}
