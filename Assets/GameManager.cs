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
        GameIsOver = false;
    }

    private void EndGame()
    {
        if(GameIsOver == false)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void WinGame()


    // Update is called once per frame
    void Update()
    {
        if(SpillCount.SpillCounter > 5)
        {
            EndGame();
        }
        else if(Countdown.TimeLeft == 0 && SpillCount.SpillCounter < 5)
        {
            WinGame();
        }
    }
}
