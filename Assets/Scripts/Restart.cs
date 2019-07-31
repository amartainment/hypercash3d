using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject winCanvas;
    public GameObject loseCanvas;
   public void RestartGame()
    {
        Time.timeScale = 1;
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
        SceneManager.LoadScene("Level1");
    }

    public void nextScene()
    {
        Time.timeScale = 1;
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
        SceneManager.LoadScene("Level2");
    }

}
