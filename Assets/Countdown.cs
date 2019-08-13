using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public Text GameTimerText;
    public float Start = 10f;

    void Update()
    {
        Start -= Time.deltaTime;
        if (Start <= 0)
        {
            GameOver();
        }
        string timerText = string.Format("{0,00}", Start);
        GameTimerText.text = timerText;
    }
    private void GameOver()
    {
        SceneManager.LoadScene(0); //If the game over scene is not 1 then replace it with the scene number that corresponds to the game over screen

    }
}