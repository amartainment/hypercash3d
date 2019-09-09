using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool GameIsOver;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    int maxSpill = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        loseCanvas.active = true;
        //SceneManager.LoadScene("GameOver");
    }

    private void WinGame()
    {
        Time.timeScale = 0;
        winCanvas.active = true;
       // SceneManager.LoadScene("YouWin");
    }


    // Update is called once per frame
    void Update()
    {
        maxSpill = GameObject.Find("SpillFeedback").GetComponent<SpillFeedback>().maxSpillsAllowed;
        if(SpillCount.SpillCounter > maxSpill)
        {
            EndGame();
        }
        else if(Countdown.TimeLeft == 0)
        {
            WinGame();
        }
    }
}
