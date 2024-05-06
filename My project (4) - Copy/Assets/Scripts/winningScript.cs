using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winningScript : MonoBehaviour
{

    public string animationName;
    [SerializeField] private Animator ledgerCase = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void win() {
        ledgerCase.Play(animationName, 0, 0.0f);
    }
}
