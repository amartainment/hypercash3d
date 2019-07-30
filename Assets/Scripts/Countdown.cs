using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text CountDownText;
    public Image CountDownFill;
    public static float TimeLeft = 30;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoseTime());
        Time.timeScale = 1;
    }

    IEnumerator LoseTime()
    {
        while (TimeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            //Debug.Log(" " + TimeLeft);
            CountDownFill.fillAmount = TimeLeft / 30;
            TimeLeft--;

        }
    }

    // Update is called once per frame
    void Update()
    {
        CountDownText.text = (" " + TimeLeft);
        

    }
}
