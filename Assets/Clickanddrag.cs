﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickanddrag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
        if(transform.position.x>100)
        {
            Destroy(gameObject);
        }
    }
}
