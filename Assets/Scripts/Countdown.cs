using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text CountDownText;
    public Image CountDownFill;
    public Slider timeSlider;
    public static float TimeLeft;
    AudioSource timeSounds;
    public AudioClip normalTick;
    public AudioClip winningTick;

    // Start is called before the first frame update
    void Start()
    {
        TimeLeft = 30;
        StartCoroutine(LoseTime());
        Time.timeScale = 1;
        
    }

    IEnumerator LoseTime()
    {
        timeSounds = GetComponent<AudioSource>();
        while (TimeLeft > 0)
        {
            if (TimeLeft < 5)
            {
                timeSounds.PlayOneShot(winningTick);
            } else
            {
                if (TimeLeft % 2 == 0) {
                    timeSounds.PlayOneShot(normalTick);
                }
            }
            timeSlider.value = timeSlider.maxValue - TimeLeft;
            yield return new WaitForSeconds(1);
            //Debug.Log(" " + TimeLeft);
            //CountDownFill.fillAmount = TimeLeft / 30;
            TimeLeft--;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //CountDownText.text = (" " + TimeLeft);
        

    }
}
