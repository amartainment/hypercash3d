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
    public Slider spillSlider;
    
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
      
        Debug.Log("spilled");
        myRenderer.material = negativeFeedback;
        myAudio.PlayOneShot(dripSound);
        spillSlider.value += 1;
        yield return new WaitForSeconds(0.5f);
        myRenderer.material = tableTop;
       
    }

    IEnumerator warningSign()
    {

        warningIcon.SetActive(true);
            yield return new WaitForSeconds(1f);
        warningIcon.SetActive(false);
          
        
    }

    public void currySpilled()
    {
        StartCoroutine("spillCurry");
    }

    public void flashWarningSign()
    {
        StartCoroutine("warningSign");
    }
}
