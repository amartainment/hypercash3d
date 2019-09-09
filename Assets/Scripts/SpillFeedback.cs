using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillFeedback : MonoBehaviour
{
    public int maxSpillsAllowed;

    public GameObject SpillSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        SpillSprite.SetActive(false);
    }

    public void SpillVisualFeedback()
    { 
    if(SpillCount.SpillCounter > 0 && SpillCount.SpillCounter <= maxSpillsAllowed)
        {
            float scaleStep = 20 / maxSpillsAllowed;
            SpillSprite.SetActive(true);
            SpillSprite.transform.localScale = SpillSprite.transform.localScale + new Vector3(scaleStep, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
}
