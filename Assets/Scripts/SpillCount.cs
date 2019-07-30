using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillCount : MonoBehaviour
{
    public static int SpillCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Curry")
        {
            SpillCounter++;
            //Debug.Log(SpillCounter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
