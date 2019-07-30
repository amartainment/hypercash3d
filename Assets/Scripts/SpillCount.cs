﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillCount : MonoBehaviour
{
    public static int SpillCounter;
    // Start is called before the first frame update
    void Start()
    {
        SpillCounter = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Curry")
        {
            SpillCounter++;
            Debug.Log(SpillCounter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
