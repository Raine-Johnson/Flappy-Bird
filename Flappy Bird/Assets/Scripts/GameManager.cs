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
    public PipeController pipeController;

    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
        if (score > highscore)
        {
            highscore = score;
        }

        mode = Mode.Menu;
    }

    // Start is called before the first frame update
    private void Start()
    {
        gameOverScreen.gameObject.SetActive(false);
        mode = Mode.Start;
        flappyBird.GetComponent<Bob>().startBob();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Restart()
    {
        mode = Mode.Start;
        //score.ResetScore();
        score = 0;
        gameOverScreen.gameObject.SetActive(false);
        pipeController.resetPipes();
        flappyBird.GetComponent<Bird>().resetBird();
    }
}

