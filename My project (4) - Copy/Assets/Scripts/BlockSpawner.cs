using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Vector3 spawnPosition;
    public GameObject block;

    public void spawnBlock() {
        Instantiate(block, spawnPosition, Quaternion.identity);
    }

}
