using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feedbackHandler : MonoBehaviour
{
    MeshRenderer myRenderer;
    public Material tableTop;
    public Material negativeFeedback;
    AudioSource myAudio;
    public AudioClip dripSound;
    public GameObject warningIcon;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spillCurry()
    {
      
       
        myAudio.PlayOneShot(dripSound);
        
        yield return new WaitForSeconds(0.5f);
        
       
    }

 

    public void currySpilled()
    {
        StartCoroutine("spillCurry");
    }

    public void flashWarningSign()
    {
      
    }
}
