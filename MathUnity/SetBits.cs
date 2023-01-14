using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SetBits : MonoBehaviour {

    int binarySequence=  8;

    void Start() 
    {
            Debug.Log(Convert.ToString(binarySequence, 2));
            // Output Binary : Wil be all 4 boxes with 1 and 3 zeros value, 1000
            // The Output : 1000
    }

    void Update() 
    {

    }

}