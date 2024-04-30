using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Material doorMaterial;
    [SerializeField] private Animator myDoor = null;
    bool isClosed = true;

    bool doorUnlocked = false;

    public string animationName;

    public string doorTag;

    void Start() {

    }

    void OnTriggerEnter(Collider other) {

        if(!doorUnlocked) {

            if(other.gameObject.tag == doorTag) {
                Debug.Log("Unlocked!!");
                //doorMaterial.color = Color.green;
                GameManager.setPuzzle1(true);

                unlockDoor(animationName);
                doorUnlocked = true;
            }
            else{
                Debug.Log("test");
            }

        }


    }

    void unlockDoor(string animationName) {

        //Transform child = transform.Find(childName);

        // If the child object is found, destroy it
        if (isClosed)
        {
            myDoor.Play(animationName, 0, 0.0f);
            isClosed = !isClosed;
            doorUnlocked = true;
        }
        else
        {
            Debug.LogWarning("Door already open!");
        }

    }

}
