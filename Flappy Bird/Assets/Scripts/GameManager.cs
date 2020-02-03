/************************
 * By: Adeline Braun
 * Last Edited: 1/30/2020
 * Description: Manages the global variables in the game
 ***********************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject flappyBird;
    int score;
    int highscore;
    public enum Mode { Start, Game, Menu }
    public Mode mode;
    public GameObject gameOverScreen;
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    private void Start()
    {



        mode = Mode.Start;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Death()
    {
        if(score > highscore)
        {
            highscore = score;
        }

        mode = Mode.Menu;
    }

    public void Restart()
    {
        score = 0;

        mode = Mode.Start;
    }
}

