using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool GameIsOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void WinGame()
    {
        SceneManager.LoadScene("YouWin");
    }


    // Update is called once per frame
    void Update()
    {
        if(SpillCount.SpillCounter > 5)
        {
            EndGame();
        }
        else if(Countdown.TimeLeft == 0)
        {
            WinGame();
        }
    }
}
